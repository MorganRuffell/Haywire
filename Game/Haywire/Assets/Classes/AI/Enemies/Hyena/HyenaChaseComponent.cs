 //////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.AI;
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.AI
{
	public struct HyenaAnimations
	{
		public const string HYENA_IDLE = "HyenaIdle";
		public const string HYENA_ATTACK = "HyenaAttack";
		public const string HYENA_DEATH = "HyenaDeath";
		public const string HYENA_TAKEDAMAGE = "HyenaTakeDamage";
	}

	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(HyenaNavMeshComponent))]
	public class HyenaChaseComponent : MonoBehaviour, ISoundSystem, IAnimationSystem
	{
		Thread ChasePlayerThread;

		private string currentState = "";

		[Header("Movement Values")]

		[Tooltip("Hyena Movement Speed")] 
		public float HyenaMovementSpeed = 5.0f;

		[Tooltip("Hyena Movement speed addition, this is added to the movement speed when closing within a range")] 
		public float MovementSpeedAddition = 8.0f;

		[Tooltip("Movement Speed Coroutine wait delay, default is .25 seconds")] 
		public float CorountineDelay = 0.25f;

		[Header("Movement Sounds")]
		public List<AudioSource> EnemyRunningSounds;

		[Header("Animation Components")]
		public Animator HyenaAnimator;

		private Rigidbody HyenaRigidBody;

		private HyenaNavMeshComponent _hyenaNavMeshComponent;

		private void Awake()
		{
			HyenaRigidBody = GetComponent<Rigidbody>();
			_hyenaNavMeshComponent = GetComponent<HyenaNavMeshComponent>();
			HyenaAnimator = GetComponent<Animator>();
	
			if (HyenaAnimator == null)
			{
				HyenaAnimator = GetComponentInChildren<Animator>();
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.tag == "Player")
			{
				HyenaAnimator.SetFloat("Movement", 0.7f);
				StartCoroutine("SpeedUp", CorountineDelay);
			}
		}

		public void Update()
		{
			HyenaAnimator.SetFloat("Movement", 0.5f);
			PlayGameSounds(EnemyRunningSounds);
			Vector3 MovementVelocity = transform.forward * HyenaMovementSpeed * Time.deltaTime;
			HyenaRigidBody.MovePosition(HyenaRigidBody.position + MovementVelocity);
		}

		private IEnumerator SpeedUp()
		{
			HyenaMovementSpeed += MovementSpeedAddition;
			HyenaAnimator.SetFloat("Movement", 0.8f);
			yield return new WaitForSeconds(1.0f);
		}

		public void ChangeAnimationState(string NewState)
		{
			if (currentState == NewState) return;

			HyenaAnimator.Play(NewState);
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
			throw new NotImplementedException();
		}

	}
}



