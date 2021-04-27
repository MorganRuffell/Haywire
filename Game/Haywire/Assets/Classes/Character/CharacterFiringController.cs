//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Singletons;
using Haywire.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace Haywire.Character
{
	public enum WeaponModes
	{
		SEMI_AUTOMATIC,
		AUTOMATIC,
		ERROR,
	}

	[RequireComponent(typeof(CharacterHealthComponent)), DisallowMultipleComponent]
	public class CharacterFiringController : MonoBehaviour
	{
		[Header("Game Manager Component")]
		public GameManagerComponent GameManager;


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
		public WeaponModes PlayerWeaponMode;
		public Image FullAutoIcon;
		public Image SemiAutoIcon;

		[Header("UI Components")]
		[Space]
		public GameObject AmmoUI;

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
				if (PlayerWeaponMode == WeaponModes.AUTOMATIC)
				{
					PlayerWeaponMode = WeaponModes.SEMI_AUTOMATIC;
					FirearmSoundPlay(ModeSwapSounds);
					FullAutoIcon.enabled = false;
					SemiAutoIcon.enabled = true;
				}
				else
				{
					PlayerWeaponMode = WeaponModes.AUTOMATIC;
					FirearmSoundPlay(ModeSwapSounds);
					FullAutoIcon.enabled = true;
					SemiAutoIcon.enabled = false;
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
				switch (PlayerWeaponMode)
				{
					case WeaponModes.SEMI_AUTOMATIC:
						StartSemiAutomaticFiring();
						break;

					case WeaponModes.AUTOMATIC:
						StartAutomaticFiring();
						break;

					case WeaponModes.ERROR:
						Debug.Log("There is an error with the character weapon mode");
						break;

					default:
						Debug.Log("You must have a selected firing mode");
						break;
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
				StartCoroutine("AutomaticFiring", 0.1f);
			}
		}

		IEnumerator AutomaticFiring(float delay)
		{
			while (Input.GetMouseButton(0))
			{
				GameManager.AmmoAmount--;

				Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
				MuzzleFlash.intensity = GunLightNormal;
				FirearmSoundPlay(AutomaticSounds);

				yield return new WaitForSecondsRealtime(delay);
			}
		}

		//Make it so that this instantiates projectiles on only click and then finish the system
		IEnumerator SemiAutomaticFiring(float delay)
		{
			GameManager.AmmoAmount--;

			Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
			MuzzleFlash.intensity = GunLightNormal;
			FirearmSoundPlay(AutomaticSounds);

			yield return null;
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
				GameManager.AmmoAmount--;
				Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
				MuzzleFlash.intensity = MuzzleFlashLightShootingIntensity;
				FirearmSoundPlay(SemiautomaticSounds);
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


