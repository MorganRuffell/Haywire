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

		public WeaponModes PlayerWeaponMode;

		[Space]
		[Space]


		[Header("Weapon Audio Slots")]
		[Tooltip("These are audio slots for the firing sounds, when you add more, I need to expand the logic checks in code.")]
		public List<AudioSource> AutomaticSounds;

		[Tooltip("These are audio slots for the firing sounds, when you add more, I need to expand the logic checks in code.")]
		public List<AudioSource> SemiautomaticSounds;

		[Header("UI Components")]
		[Space]
		public GameObject AmmoUI;

		private void Update()
		{
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
			}

			if (Input.GetMouseButtonDown(0))
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
			yield return new WaitForSecondsRealtime(delay);
			GameManager.AmmoAmount--;

			Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
			FirearmSoundPlay(AutomaticSounds);
			StartCoroutine("AutomaticFiring", 0.1f);
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
				FirearmSoundPlay(SemiautomaticSounds);
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


