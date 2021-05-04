using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.AI
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(LeopardNavMeshComponent))]

	public class LeopardChaseComponent : MonoBehaviour, ISoundSystem, IAnimationSystem
	{
		private string currentState = "";

		public LeopardFiringComponent FiringComponent;

		[Header("Movement Values")]
		[Tooltip("Hyena Movement Speed")]
		public float LeopardMovementSpeed = 5.0f;

		[Tooltip("Hyena Movement speed addition, this is added to the movement speed when closing within a range")]
		public float MovementSpeedAddition = 8.0f;

		[Tooltip("Movement Speed Coroutine wait delay, default is .25 seconds")]
		public float CorountineDelay = 0.25f;

		[Header("Movement Sounds")]
		public List<AudioSource> EnemyRunningSounds;

		[Header("Animation Components")]
		public Animator LeopardAnimator;

		private Rigidbody LeopardRigidBody;

		private LeopardNavMeshComponent _LeopardNavmeshComponent;

		[Header("AI Controller")]
		private bool isRanged;

		public List<Vector3> FiringLocations = new List<Vector3>();

		public float PlayerRadius;

		private System.Random random = new System.Random();

		void Awake()
		{
			if (random.Next(2) == 0)
			{
				isRanged = true;
			}
			
			LeopardRigidBody = GetComponent<Rigidbody>();
			_LeopardNavmeshComponent = GetComponent<LeopardNavMeshComponent>();
			LeopardAnimator = GetComponent<Animator>();

			if (LeopardAnimator == null)
			{
				LeopardAnimator = GetComponentInChildren<Animator>();
			}
		}

		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (isRanged)
			{
				//Gets a list of locations, selects a random one.
				Int32 locallocationindex = random.Next(0, FiringLocations.Count);

				for (int i = 0; i <= FiringLocations.Count; i++)
				{
					if (i == locallocationindex)
					{
						MoveToTargetLocation(FiringLocations[locallocationindex]);	
					}
				}
					
			}
			else
			{
				ChasePlayer();
			}
		}

		private void MoveToTargetLocation(Vector3 FiringLocation)
		{
			LeopardAnimator.SetFloat("Movement", 0.5f);
			Vector3 MovementVelocity = transform.forward * LeopardMovementSpeed * Time.deltaTime;
			PlayGameSounds(EnemyRunningSounds);

			if (gameObject.transform.position == FiringLocation)
			{
				FiringComponent.FireProjectile();

				//Fire projectiles at the players location
				//The projectiles cause damage, using a projectile damage component;
			}
		}

		private void ChasePlayer()
		{
			LeopardAnimator.SetFloat("Movement", 0.5f);
			PlayGameSounds(EnemyRunningSounds);
			Vector3 MovementVelocity = transform.forward * LeopardMovementSpeed * Time.deltaTime;
			LeopardRigidBody.MovePosition(LeopardRigidBody.position + MovementVelocity);
		}

		

		public void ChangeAnimationState(string NewState)
		{
			if (currentState == NewState) return;

			LeopardAnimator.Play(NewState);
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
