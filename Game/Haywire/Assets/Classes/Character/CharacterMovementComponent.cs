//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Character
{
	[RequireComponent(typeof(CharacterHealthComponent))]
	[RequireComponent(typeof(CharacterControlComponent))]
	[DisallowMultipleComponent]
	public class CharacterMovementComponent : MonoBehaviour, ISoundSystem, IAnimationSystem
	{

		private Vector3 velocity;

		private float horizontal;
		private float vertical;

		[Header("Jump and Animation Public Variables")]
		public float WalkSpeed = 6.0f;
		public Int16 WalkSpeedMultiplier = 3;
		public Int16 JumpPower = 4;
		public float AnimationTurnSpeed = 0f;
		public float SprintTrigger = 0.5f;
		public float AimingSpeed = 3.0f;

		[HideInInspector, SerializeField]
		public bool IsTouchingEnviroment = true;
		//private bool IsHeld = false;

		[Header("Setup for GameObjects")]
		[SerializeField]
		public Rigidbody PlayerRigidbody;
		public Animator PlayerAnimator;
		public Collider PlayerCollider;
		public GameObject _mainCamera;

		[HideInInspector]
		public bool IsSprinting;

		[Header("Player Sounds")]
		public List<AudioSource> breathingSounds;
		public List<AudioSource> MovementSounds;
		public List<AudioSource> LandingSounds;

		[Header("PlayerAnimations")]
		PlayerAnimations playerAnimations;
		[HideInInspector]
		public string currentState;
		public string Player_Jump { get; private set; }

		public float IdleDelay = 10.0f;

		[HideInInspector]
		private protected float _IdleDelay
		{
			get
			{
				return IdleDelay;
			}
			set
			{
				_IdleDelay = IdleDelay;
			}
		}

		private void Awake()
		{

		}

		//Could make it automatic so that field are automatically assigned on Awake

		void Update()
		{
			PlayerAnimator.SetFloat("Movement", 0.0f);

			float horizontal = Input.GetAxisRaw("Horizontal");
			float vertical = Input.GetAxisRaw("Vertical");

			PlayGameSounds(breathingSounds);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				//Replace this with animationController.Play(Jump);

				PlayerAnimator.SetFloat("Movement", 0.0f);
				PlayerRigidbody.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
				//ChangeAnimationState(Player_Jump);
			}

			Move(horizontal, vertical);
		}

		private void Move(float horizontal, float vertical)
		{
			if (horizontal != 0 || vertical != 0)
			{
				PlayerAnimator.SetFloat("IsBored", 0.0f);
				PlayerAnimator.SetBool("IsIdle", false);

				//Make these play on animation events only.
				PlayGameSounds(MovementSounds);

				velocity.Set(horizontal, 0.0f, 0.0f);

				if (PlayerAnimator.GetBool("IsIdle").Equals(false))
				{
					velocity = velocity.normalized * WalkSpeed * Time.deltaTime;
				
					PlayerRigidbody.MovePosition(PlayerRigidbody.position + velocity);
					PlayerAnimator.SetFloat("Movement", 0.9f);
				
					HandleCharacterOrientation(horizontal, vertical);
				}

				else
				{
					velocity = velocity.normalized * WalkSpeed * Time.deltaTime;

					PlayerRigidbody.MovePosition(PlayerRigidbody.position + velocity);
					PlayerAnimator.SetFloat("Movement", 0.9f);

					HandleCharacterOrientation(horizontal, vertical);
				}
			}
			else
			{
				PlayerAnimator.SetBool("IsIdle", true);
				StopGameSounds(MovementSounds);

				//Probably should do this with a coroutine?
				Invoke("HandleCharacterBoredom", _IdleDelay);

			}
		}

		private void HandleCharacterOrientation(float horizontal, float vertical)
		{
			if (vertical > 0)
			{
				PlayerAnimator.SetFloat("Movement", 0.0f);
				StartCoroutine(PlayerForwardMovement(AnimationTurnSpeed, vertical));
			}

			if (horizontal < 0)
			{
				StartCoroutine(PlayerLeftMovement(AnimationTurnSpeed, horizontal));
			}

			if (horizontal > 0)
			{
				StartCoroutine(PlayerRightMovement(AnimationTurnSpeed, horizontal));
			}
		}

		private void HandleCharacterBoredom()
		{
			PlayerAnimator.SetFloat("IsBored", 0.4f);
		}

		private IEnumerator PlayerRightMovement(float AnimationTurnSpeed, float MovementSpeed)
		{
			if (PlayerAnimator.GetBool("IsIdle").Equals(false))
			{
				transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));

				if (MovementSpeed > SprintTrigger)
				{
					Sprinting(MovementSpeed);
				}
			}

			if (MovementSpeed > SprintTrigger)
			{
				Sprinting(MovementSpeed);
			}

			yield return new WaitForSeconds(AnimationTurnSpeed);
		}

		private IEnumerator PlayerLeftMovement(float AnimationTurnSpeed, float MovementSpeed)
		{
			if (PlayerAnimator.GetBool("IsIdle").Equals(false))
			{
				transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));

				if (MovementSpeed > SprintTrigger)
				{
					Sprinting(MovementSpeed);
				}
			}

			if (MovementSpeed > SprintTrigger)
			{
				Sprinting(MovementSpeed);
			}

			yield return new WaitForSeconds(AnimationTurnSpeed);
		}

		private IEnumerator PlayerForwardMovement(float AnimationTurnSpeed, float MovementSpeed)
		{
			transform.rotation = Quaternion.Euler(new Vector3(0, 360, 0));
			yield return new WaitForSeconds(AnimationTurnSpeed);
		}


		public void ChangeAnimationState(string NewState)
		{
			if (currentState == NewState) return;

			PlayerAnimator.Play(NewState);
		}

		private void Sprinting(float MovementSpeed)
		{
			PlayerAnimator.SetFloat("Movement", 1.0f);
			IsSprinting = true;
			//Adjust the float value. The execution thread will not penetrate this deep without the above paramaters being set.
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.gameObject.tag == "Environment")
			{
				PlayerAnimator.SetBool("Jump", false);
				PlayerAnimator.SetFloat("Movement", 0.0f);
				EnviromentCollision_Handler();
			}
		}
		private void OnCollisionExit(Collision collision)
		{
			if (collision.gameObject.tag == "Environment")
			{
				PlayerAnimator.SetFloat("Movement", 0.0f);
				AirCollision_Handler();
			}
		}

		private void AirCollision_Handler()
		{
			PlayerAnimator.SetFloat("Movement", 0.0f);
			IsTouchingEnviroment = true;
		}

		private void EnviromentCollision_Handler()
		{
			PlayerAnimator.SetFloat("Movement", 0.0f);
			PlayerAnimator.SetBool("Jump", false);
			PlayGameSounds(LandingSounds);
			IsTouchingEnviroment = false;
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
			}
		}

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			if (SoundList.Count > 0)
			{
				//Could be done in a foreach loop but felt that a traditional for loop would be better?
				foreach (AudioSource audio in SoundList)
				{
					if (audio.isPlaying == true)
					{
						audio.Stop();
					}

				}

			}
			else
			{
				Debug.LogWarning("Sound List is empty. This will need elements to play sounds.");
			}


		}

	}
}

