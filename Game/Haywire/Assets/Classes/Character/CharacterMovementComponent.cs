//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Character
{	
	[RequireComponent(typeof(CharacterHealthComponent))]
	public class CharacterMovementComponent : MonoBehaviour
	{
		private Vector3 velocity;

		[Header("Jump and Animation Public Variables")]
		public float WalkSpeed = 6.0f;
		public int WalkSpeedMultiplier = 3;
		public const float JumpPower = 2;
		public const float AnimationTurnSpeed = 0f;


		[HideInInspector]
		public bool IsTouchingEnviroment = true;
		private bool IsHeld = false;

		[SerializeField]
		public Rigidbody PlayerRigidbody;
		public Animator PlayerAnimator;
		public CapsuleCollider PlayerCollider;


		// Start is called before the first frame update
		void Start()
		{
		}

		// Update is called once per frame
		void Update()
		{
			float horizontal = Input.GetAxisRaw("Horizontal");
			float vertical = Input.GetAxisRaw("Vertical");

			Move(horizontal, vertical);
		
		}

		private void Move (float horizontal, float vertical)
		{
			velocity.Set(horizontal, 0.0f, vertical);
			velocity = velocity.normalized * WalkSpeed * Time.deltaTime;
			PlayerRigidbody.MovePosition(PlayerRigidbody.position + velocity);

			//Implement functionality for any additional 3D movement.
		}
	}
}

