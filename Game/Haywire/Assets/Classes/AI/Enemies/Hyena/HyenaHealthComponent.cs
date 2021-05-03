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
	public class HyenaHealthComponent : EnemyHealthComponent
	{
		[Header("Hyena Movement Component")]
		private HyenaChaseComponent chaseComponent;
		private GameManagerComponent GameManager;

		[Header("Hyena Score")]
		public int Score = 10;

		[Header("Hyena Health")]
		public int HyenaMaxHealth = 50;
		public int HyenaCurrentHealth;

		[Header("Hyena Slowed Values")]
		public int HyenaSlowedThreshold = 10;
		public float HyenaSlowedIncrement = 20.0f;

		public override void Awake()
		{
			HyenaMaxHealth = HyenaCurrentHealth;
			chaseComponent = GetComponent<HyenaChaseComponent>();
			GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerComponent>();
		}

		public override void TakeDamage(int Amount)
		{
			base.TakeDamage(Amount);

			HyenaCurrentHealth = -Amount;
		}

		public override void Update()
		{
			base.Update();

			if (HyenaCurrentHealth % HyenaSlowedThreshold == 0 )
			{
				Slow(chaseComponent.HyenaMovementSpeed);

				if (HyenaCurrentHealth >= 0)
				{
					Die();
				}
			}
			else
			{

			}
		}

		public override void Die()
		{
			GameManager.IncreaseScore(Score);
			Destroy(this);
		}

		public override void Slow(float HyenaMovementSpeed)
		{
			HyenaMovementSpeed = HyenaMovementSpeed - HyenaSlowedIncrement;
		}
	}

}
