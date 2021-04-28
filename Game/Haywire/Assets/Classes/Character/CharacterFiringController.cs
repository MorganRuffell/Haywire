//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Haywire.Singletons;
using Haywire.Gameplay;
using Haywire.UI;

namespace Haywire.Character
{
	[RequireComponent(typeof(CharacterHealthComponent)), DisallowMultipleComponent]
	public class CharacterFiringController : MonoBehaviour
	{
		[Header("Game Manager Component")]
		public GameManagerComponent GameManager;

		[Header("")]
		public FirearmControlComponent firearmControl;

		[Header("Character Firing Attributes")]
		[Tooltip("This is the place that bullet GameObjects instantiate from")]
		public Transform spawnPoint;

		public GameObject projectile;

		public float FireRate = 1.0f;
		public float timer = 0.0f;

		public float FiringRange = 500.0f;

		[Header("Gun Spot Light")]
		public Light GunSpotLight;
		private bool GunLightOn = true;


		[Header("Muzzle Flash Attributes")]
		public Light MuzzleFlash;
		public float MuzzleFlashLightShootingIntensity = 15.0f;
		private float GunLightNormal = 0.0f;

		[Header("Character Damage Component")]
		public float Damage = 50.0f;

		[Header("Firing mode controller")]
		public bool IsPlayerAutomatic = true;
		public Image FullAutoIcon;
		public Image SemiAutoIcon;

		[Header("UI Components")]
		public GameObject AmmoUI;

		[Space]
		[Space]
		[Space]

		[Header("Weapon Audio Slots")]
		[Tooltip("These are audio slots for the firing sounds, when you add more, I need to expand the logic checks in code.")]
		public List<AudioSource> AutomaticSounds;

		[Tooltip("These are audio slots for the firing sounds, when you add more, I need to expand the logic checks in code.")]
		public List<AudioSource> SemiautomaticSounds;

		[Tooltip("These are audio slots for the swap of the gun mode sounds.")]
		public List<AudioSource> ModeSwapSounds;


		private void Update()
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				if (IsPlayerAutomatic == true)
				{
					IsPlayerAutomatic = false;
					FirearmSoundPlay(ModeSwapSounds);
					FullAutoIcon.enabled = false;
					SemiAutoIcon.enabled = true;
					return;
				}
				else
				{
					IsPlayerAutomatic = true;
					FirearmSoundPlay(ModeSwapSounds);
					FullAutoIcon.enabled = true;
					SemiAutoIcon.enabled = false;
					return;
				}
			}

			if (Input.GetKeyDown(KeyCode.Q))
			{
				if (GunLightOn == true)
				{
					GunLightOn = !GunLightOn;
					GunSpotLight.intensity = 0;
				}
				else
				{
					GunLightOn = !GunLightOn;
					GunSpotLight.intensity = 60;
				}
			}

			if (MouseManager._CanFire == true)
			{
				Fire();
			}
		}

		private void Fire()
		{
			if (Input.GetMouseButtonUp(0))
			{
				StopAllCoroutines();
				MuzzleFlash.intensity = GunLightNormal;
			}

			if (Input.GetMouseButton(0))
			{
				if (IsPlayerAutomatic)
				{
					StartAutomaticFiring();
				}
				else
				{
					StartSemiAutomaticFiring();
				}
			}
		}

		private void StartAutomaticFiring()
		{
			if (GameManager.AmmoAmount <= 0)
			{
				Debug.ClearDeveloperConsole();
				Debug.Log("Out of Ammo");
				return;
			}
			else
			{
				StartCoroutine("AutomaticFiring", 1f);
			}
		}

		IEnumerator AutomaticFiring(float delay)
		{
			while (Input.GetMouseButton(0))
			{
				Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
				
				MuzzleFlash.intensity = GunLightNormal;
				FirearmSoundPlay(AutomaticSounds);
				firearmControl.FiringParticles.Play();
				yield return new WaitForSeconds(delay);
				GameManager.AmmoAmount--;
			}
		}

		//Make it so that this instantiates projectiles on only click and then finish the system
		IEnumerator SemiAutomaticFiring(float delay)
		{
			GameManager.AmmoAmount--;
			Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
			firearmControl.FiringParticles.Play();
			yield return new WaitForSeconds(3);
			MuzzleFlash.intensity = GunLightNormal;
			FirearmSoundPlay(AutomaticSounds);
		}

		private void StartSemiAutomaticFiring()
		{
			if (GameManager.AmmoAmount <= 0)
			{
				Debug.ClearDeveloperConsole();
				Debug.Log("Out of Ammo");
				return;
			}
			else
			{
				StartCoroutine(SemiAutomaticFiring(2.0f));
			}
		}


		private void FirearmSoundPlay(List<AudioSource> SoundList)
		{
			if (SoundList.Count > 0)
			{
				var random = new System.Random();
				int SoundIndex = random.Next(SoundList.Count);

				SoundList[SoundIndex].Play();
			}
			else
			{
				Debug.LogWarning("Sound List is empty. This will need elements to play sounds.");
				throw new Exception();
			}
		}

	}
}


