using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.AI;
using Haywire.Singletons;
using System;

namespace Haywire.AI
{
	public class LeopardHealthComponent : EnemyHealthComponent
	{
		[Header("Leopard Movement Component")]
		private LeopardChaseComponent chaseComponent;
		private GameManagerComponent GameManager;

		[Header("Leopard Score")]
		public int Score = 10;

		[Header("Leopard Health")]
		public int LeopardMaxHealth = 50;
		public int LeopardCurrentHealth;

		[Header("Leopard Slowed Values")]
		public int LeopardSlowedThreshold = 20;
		public float LeopardSlowedIncrement = 20.0f;

		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		public new void Update()
		{
			if (LeopardCurrentHealth % LeopardSlowedThreshold == 0)
			{
				Slow(chaseComponent.LeopardMovementSpeed);

				if (LeopardCurrentHealth >= 0)
				{
					Die();
				}
			}
			else
			{

			}
		}

		public new void Awake()
		{

		}

		public override void TakeDamage(int Damage)
		{
			throw new NotImplementedException();
		}

		public override void TakeDamage(float Damage)
		{
			throw new NotImplementedException();
		}

		public override void Die()
		{
			throw new NotImplementedException();
		}

		public override void Slow(float LeopardMovementSpeed)
		{
			LeopardMovementSpeed -= LeopardSlowedIncrement;
		}
	}
}
