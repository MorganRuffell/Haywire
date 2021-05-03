using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.AI
{

	public class LeopardDamageComponent : EnemyDamageComponent, ISoundSystem
	{
		[Header("Enemy Damage Control Fields")]
		public int _Damage;
		public float EnemyDamageMultiplier = 1.0f;
		public string TargetTag;

		[Space]

		[Header("Enemy Damage Audio Sounds")]
		public List<AudioSource> EnemyAudioAttackSounds;

		[SerializeField] public Animator animationController;


		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

		}

		public override void OnTriggerEnter(Collider other)
		{
			throw new NotImplementedException();
		}

		public override void EnemyCollisionHandler(Collider CollidingObject)
		{
			throw new NotImplementedException();
		}

		public override IEnumerator PlayAttackAnimation()
		{
			throw new NotImplementedException();
		}

		public override void PlayGameSounds(List<AudioSource> SoundList)
		{
			throw new NotImplementedException();
		}

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			throw new NotImplementedException();
		}
	}
}
