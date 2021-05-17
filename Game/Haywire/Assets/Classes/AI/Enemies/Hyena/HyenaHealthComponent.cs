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
using UnityEngine.AI;

namespace Haywire.AI
{
	public class HyenaHealthComponent : MonoBehaviour, IAnimationSystem, IResolveLoading
	{
		[Header("Hyena Movement Component")]
		private HyenaChaseComponent chaseComponent;
		private HyenaNavMeshComponent hyenaNavMesh;
		private GameManagerComponent GameManager;
		private Animator HyenaAnimator;
		private Rigidbody HyenaRigidbody;
		private NavMeshAgent NavMeshAgentComponent;
		private HyenaDamageComponent DamageComponent;


		[Header("Colliders")]
		public BoxCollider BoxDamageCauser;
		public SphereCollider SphereTrigger;



		[Header("Hyena Score")]
		public int Score = 20;

		[Header("Hyena Health")]
		public int HyenaMaxHealth = 50;
		public int HyenaCurrentHealth;
		public float HyenaDeathDelay = 5.0f;


		[Header("Hyena Slowed Values")]
		public int HyenaSlowedThreshold = 10;
		public float HyenaSlowedIncrement = 20.0f;

		[HideInInspector]
		public bool EnemyisDead;

		public void Awake()
		{
			HyenaCurrentHealth = HyenaMaxHealth;

			ResolveLoading();
		}

		public void ResolveLoading()
		{
			NavMeshAgentComponent = GetComponent<NavMeshAgent>();
			HyenaAnimator = GetComponentInChildren<Animator>();
			chaseComponent = GetComponent<HyenaChaseComponent>();
			hyenaNavMesh = GetComponent<HyenaNavMeshComponent>();
			DamageComponent = GetComponent<HyenaDamageComponent>();
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
			NavMeshAgentComponent.isStopped = true;
			HyenaCurrentHealth = - (int) Amount;
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
			NavMeshAgentComponent.enabled = false;
			GameManager.IncreaseScore(Score);
			Destroy(BoxDamageCauser);
			Destroy(SphereTrigger);

			HyenaAnimator.SetBool("IsDead", true);
			EnemyisDead = true;
			Destroy(gameObject, HyenaDeathDelay);
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
