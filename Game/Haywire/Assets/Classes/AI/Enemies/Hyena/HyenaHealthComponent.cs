//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Singletons;
using Haywire.Systems;

namespace Haywire.AI
{
	public class HyenaHealthComponent : MonoBehaviour, IAnimationSystem
	{
		[Header("Hyena Movement Component")]
		private HyenaChaseComponent chaseComponent;
		private HyenaNavMeshComponent hyenaNavMesh;
		private GameManagerComponent GameManager;
		private Animator HyenaAnimator;
		private Rigidbody HyenaRigidbody;


		[Header("Hyena Score")]
		public int Score = 20;

		[Header("Hyena Health")]
		public int HyenaMaxHealth = 50;
		public int HyenaCurrentHealth;

		[Header("Hyena Slowed Values")]
		public int HyenaSlowedThreshold = 10;
		public float HyenaSlowedIncrement = 20.0f;

		[HideInInspector]
		public bool EnemyisDead;

		public void Awake()
		{
			HyenaCurrentHealth = HyenaMaxHealth;

			HyenaAnimator = GetComponentInChildren<Animator>();
			chaseComponent = GetComponent<HyenaChaseComponent>();
			hyenaNavMesh = GetComponent<HyenaNavMeshComponent>();
			HyenaRigidbody = GetComponent<Rigidbody>();

			GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerComponent>();
		}

		public void TakeDamage(int Amount)
		{
			HyenaCurrentHealth =- Amount;
			HyenaAnimator.SetTrigger("TakeDamage");
		}

		public void TakeDamage(float Amount)
		{
			HyenaCurrentHealth =- (int) Amount;
			HyenaAnimator.SetTrigger("TakeDamage");
		}


		public void Update()
		{
			CheckState();
		}

		public void CheckState()
		{
			if (EnemyisDead)
			{
				HyenaAnimator.SetTrigger("IsDead");
				Die();
			}

			if (HyenaCurrentHealth == 0)
			{
				EnemyisDead = true;
				HyenaAnimator.SetTrigger("IsDead");
				Die();
			}

			if (HyenaCurrentHealth < 0)
			{
				EnemyisDead = true;
				HyenaAnimator.SetTrigger("IsDead");
				Die();
			}
		}

		public void Die()
		{
			Destroy(chaseComponent);
			Destroy(hyenaNavMesh);
			HyenaRigidbody.constraints = RigidbodyConstraints.FreezeAll;

			GameManager.IncreaseScore(Score);
			HyenaAnimator.SetBool("IsDead", true);
			EnemyisDead = true;
			Destroy(gameObject, 0.5f);
		}

		public void Slow(float HyenaMovementSpeed)
		{
			HyenaMovementSpeed = HyenaMovementSpeed - HyenaSlowedIncrement;
		}

		public void ChangeAnimationState(string NewState)
		{
			HyenaAnimator.Play(NewState);
		}
	}

}
