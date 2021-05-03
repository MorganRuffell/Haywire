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


		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

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
