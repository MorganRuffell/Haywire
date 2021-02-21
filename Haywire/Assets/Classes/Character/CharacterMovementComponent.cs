//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Character
{	
	[RequireComponent(typeof(CharacterHealthComponent)), DisallowMultipleComponent]
	public class CharacterMovementComponent : MonoBehaviour
	{
		private Vector3 velocity;

		[Header("Jump and Animation Public Variables")]
		public float WalkSpeed = 6.0f;
		public int WalkSpeedMultiplier = 3;
		public int JumpPower = 4;
		public const float AnimationTurnSpeed = 0f;

		[HideInInspector, SerializeField]
		public bool IsTouchingEnviroment = true;
		private bool IsHeld = false;

		[Header("Setup for GameObjects")]
		[SerializeField]
		public Rigidbody PlayerRigidbody;
		public Animator PlayerAnimator;
		public CapsuleCollider PlayerCollider;
		public GameObject _mainCamera;

		void Update()
		{
			float horizontal = Input.GetAxisRaw("Horizontal");

			if (Input.GetKeyDown(KeyCode.Space))
			{
				PlayerRigidbody.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
				PlayerAnimator.SetTrigger("Jump");
			}

			Move(horizontal);
		}

		private void Move (float horizontal)
		{
			velocity.Set(horizontal, 0.0f, 0.0f);
			velocity = velocity.normalized * WalkSpeed * Time.deltaTime;
			PlayerRigidbody.MovePosition(PlayerRigidbody.position + velocity);
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.gameObject.tag == "Environment")
			{
				EnviromentCollision_Handler();
			}
		}
		private void OnCollisionExit(Collision collision)
		{
			if (collision.gameObject.tag == "Environment")
			{
				AirCollision_Handler();
			}
		}

		private void AirCollision_Handler()
		{
			IsTouchingEnviroment = true;
		}

		private void EnviromentCollision_Handler()
		{
			IsTouchingEnviroment = false;
		}

	}
}

