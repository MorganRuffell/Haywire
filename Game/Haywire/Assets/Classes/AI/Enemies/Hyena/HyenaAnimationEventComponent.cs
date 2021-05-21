using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.AI;
using System;
using System;

namespace Haywire.AI
{
	public class HyenaAnimationEventComponent : EnemyAnimationEventComponent, ISoundSystem
	{
		public List<AudioSource> MovementSounds;
		public List<AudioSource> AttackSounds;

		public new void Touch()
		{
			PlayGameSounds(MovementSounds);
		}

		public override void Attack()
		{
			base.Attack();

			PlayGameSounds(AttackSounds);

		}

		public override void TakeDamage()
		{
			base.TakeDamage();	
		}

		public override void OnDeath()
		{
			base.OnDeath();
		}

		public void PlayGameSounds(List<AudioSource> SoundList)
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
			throw new System.NotImplementedException();
		}
	}
}



