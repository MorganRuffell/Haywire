using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.AI;
using Haywire.Character;

namespace Haywire.AI
{
	//[RequireComponent(typeof())]
	public class HyenaDamageComponent : EnemyDamageComponent, ISoundSystem
	{
		[Header("Enemy Damage Control Fields")]
		public int _Damage;
		public float EnemyDamageMultiplier = 1.0f;
		public string TargetTag;

		[Space]

		[Header("Enemy Damage Audio Sounds")]
		public List<AudioSource> EnemyAudioAttackSounds;

		[SerializeField] public Animator animationController;

		public override void OnTriggerEnter(Collider other)
		{
			EnemyCollisionHandler(other);
		}

		public override void EnemyCollisionHandler(Collider CollidingObject)
		{
			if (CollidingObject.gameObject.CompareTag("Player"))
			{
				StartCoroutine(PlayAttackAnimation());
				CollidingObject.GetComponent<CharacterHealthComponent>().TakeDamage(_Damage);
			}
		}

		public override IEnumerator PlayAttackAnimation()
		{
			animationController.SetBool("AttackTrigger", true);

			//Create a system similar to the player, will not take too long.
			PlayGameSounds(EnemyAudioAttackSounds);

			yield return new WaitForSeconds(2.0f);
		}

		public override void PlayGameSounds(List<AudioSource> SoundList)
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

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			throw new NotImplementedException();
		}
	}
}
