//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
////	
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Singletons;
using Haywire.UI;

namespace Haywire.Character
{
	[RequireComponent(typeof(CharacterMovementComponent))]
	public class CharacterHealthComponent : MonoBehaviour
	{
		//Player Health Values
		public int MaxHealth = 100;
		public int CurrentHealth;

		public float DeathDelay = 2.0f;
		public Rigidbody PlayerRigidBody;

		[Header("Health UI Alpha Control")]
		public UIAlphaControl AlphaController;
		public float HealthUIAlphaController = 1.0f;

		[SerializeField]
		[Header("Take Damage Sounds")]
		[Tooltip("These are take damage sounds, as with all of the other audio collections. But this one is double barrelled! Just because I feel like doing something complex")]
		public List<AudioSource> TakeDamageSounds_Set1;

		[Tooltip("These are take damage sounds, as with all of the other audio collections. But this one is double barrelled! Just because I feel like doing something complex")]
		public List<AudioSource> TakeDamageSounds_Set2;

		[Space]
		[Space]

		[Header("Death Sounds")]
		[Tooltip("These are death sounds, they are just TakeDamage sounds but they have their own little collection. I like to collect things...")]
		public List<AudioSource> DeathSounds;

		private void Awake()
		{
			CurrentHealth = MaxHealth;
		}

		// Update is called once per frame
		void Update()
		{
			UI_HealthPercentage();

			if (CurrentHealth <= 0)
			{
				GameManagerComponent.GameManager.IsAlive = false;
				Death();
			}
		}

		public void TakeDamage(int Amount)
		{
			AlphaController.Appear(HealthUIAlphaController);
			DamageSoundPlay(TakeDamageSounds_Set1, TakeDamageSounds_Set2);
			CurrentHealth -= Amount;
		}

		public void TakeDamage(float Amount)
		{	
			AlphaController.Appear(HealthUIAlphaController);
			DamageSoundPlay(TakeDamageSounds_Set2, TakeDamageSounds_Set2);
			CurrentHealth -= (int) Amount;
		}


		public void Death()
		{
			if (GameManagerComponent.GameManager.IsAlive == false)
			{
				DamageSoundPlay(DeathSounds);

				//Lock all rb constraints
				PlayerRigidBody.constraints = RigidbodyConstraints.FreezePositionX;
				PlayerRigidBody.constraints = RigidbodyConstraints.FreezePositionZ;
				PlayerRigidBody.constraints = RigidbodyConstraints.FreezePositionY;

				Destroy(gameObject, 1.0f);
			}
		}

		public float UI_HealthPercentage()
		{
			return (float) CurrentHealth / MaxHealth;
		}

		private void DamageSoundPlay(List<AudioSource> SoundList)
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

		//Function overload for being damaged sounds, designed to take two lists
		private void DamageSoundPlay(List<AudioSource> SoundList0, List<AudioSource> SoundList1)
		{
			var HasPlayed = false;

			if (SoundList0.Count > 0 || SoundList1.Count > 0)
			{ 
				if (HasPlayed)
				{
					var random = new System.Random();
					int SoundIndex = random.Next(SoundList0.Count);

					SoundList0[SoundIndex].Play();
					HasPlayed = true;
				}
				else
				{
					var random = new System.Random();
					int SoundIndex = random.Next(SoundList1.Count);

					SoundList1[SoundIndex].Play();
				}
			}
			else
			{
				Debug.LogWarning("Sound List0 and Sound List 1 are empty. These will need elements to play sounds.");
				throw new Exception();
			}

		}

	}
}



