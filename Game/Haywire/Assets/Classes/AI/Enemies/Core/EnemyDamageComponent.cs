//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Character;

namespace Haywire.AI
{
	public abstract class EnemyDamageComponent : MonoBehaviour
	{
		[Header("Enemy Damage Control Fields")]
		private int damage;
		private float EnemyDamageMultiplier = 1.0f;

		[Space]

		[Header("Enemy Damage Audio Sounds")] List<AudioSource> EnemyAudioAttackSounds;

		private Animator animationController;

		public virtual void OnTriggerEnter(Collider other)
		{
			EnemyCollisionHandler(other);
		}

		public virtual void EnemyCollisionHandler(Collider CollidingObject)
		{
			if (CollidingObject.gameObject.CompareTag("Player"))
			{
				StartCoroutine(PlayAttackAnimation());
				CollidingObject.GetComponent<CharacterHealthComponent>().TakeDamage(damage);
			}
		}

		public virtual IEnumerator PlayAttackAnimation()
		{
			animationController.SetBool("AttackTrigger", true);

			//Create a system similar to the player, will not take too long.
			PlayGameSounds(EnemyAudioAttackSounds);

			yield return new WaitForSeconds(2.0f);
		}
		
		public virtual void PlayGameSounds(List<AudioSource> SoundList)
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

