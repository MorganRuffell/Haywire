//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Singletons;

namespace Haywire.AI
{
	public class HyenaHealthComponent : MonoBehaviour, IAnimationSystem
	{
		[Header("Hyena Movement Component")]
		private HyenaChaseComponent chaseComponent;
		private GameManagerComponent GameManager;
		private Animator HyenaAnimator;

		[Header("Hyena Score")]
		public int Score = 10;

		[Header("Hyena Health")]
		public int HyenaMaxHealth = 50;
		public int HyenaCurrentHealth;

		[Header("Hyena Slowed Values")]
		public int HyenaSlowedThreshold = 10;
		public float HyenaSlowedIncrement = 20.0f;

		public void Awake()
		{
			HyenaCurrentHealth = HyenaMaxHealth;
			chaseComponent = GetComponent<HyenaChaseComponent>();
			GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerComponent>();
		}

		public void TakeDamage(int Amount)
		{
			HyenaCurrentHealth =- Amount;
			ChangeAnimationState("HyenaTakeDamage");
		}

		public void TakeDamage(float Amount)
		{
			HyenaCurrentHealth =- (int) Amount;
			ChangeAnimationState("HyenaTakeDamage");
		}


		public void Update()
		{
			if (HyenaCurrentHealth < HyenaSlowedThreshold)
			{
				Slow(chaseComponent.HyenaMovementSpeed);

				if (HyenaCurrentHealth <= 0)
				{
					ChangeAnimationState("HyenaDeath");
					Die();
				}
			}
			else
			{

			}
		}

		public void Die()
		{
			GameManager.IncreaseScore(Score);
			Destroy(this, 0.5f);
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
