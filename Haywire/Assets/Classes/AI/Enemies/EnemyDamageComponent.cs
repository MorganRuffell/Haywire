//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Character;
using System;
using UnityEngine;

namespace Haywire.AI
{
	[RequireComponent(typeof(NavMeshControllerComponent))]
	[RequireComponent(typeof(EnemyHealthComponent))]
	public class EnemyDamageComponent : Damage
	{
		[Header("Enemy Damage Control Fields")]
		public Int16 Damage = 10;
		public float EnemyDamageMultiplier = 1.0f;
		public string TargetTag;

		private void Awake()
		{
			
		}

		private void OnTriggerEnter(Collider other)
		{
			EnemyCollisionHandler(other);
		}

		void EnemyCollisionHandler(Collider CollidingObject)
		{
			if (CollidingObject.gameObject.CompareTag("Player"))
			{
				CollidingObject.gameObject.GetComponent<CharacterHealthComponent>().TakeDamage(Damage);
			}
		}
	}
}

