//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Haywire.AI;

namespace Haywire.Gameplay
{
	[RequireComponent(typeof(Rigidbody))]
	[DisallowMultipleComponent]
	public class ProjectileComponent : Damage
	{
		[Header("Player Projectile Controller")]
		public Int16 damage = 20;

		public Int16 force = 50;

		public Int16 Lifetime = 30;

		public Int16 EnemyCollisionLifetime = 1;

		public Rigidbody BulletCollsionRb;

		public string targetTag;

		void Awake()
		{
			targetTag = "Enemy";			
		}

		private void Start()
		{
			BulletCollsionRb = GetComponent<Rigidbody>();
			BulletCollsionRb.AddForce(transform.forward * force, ForceMode.Impulse);
		}

		private void OnCollisionEnter(Collision collision)
		{
			CollisionHandler(collision);
		}

		private void CollisionHandler(Collision collision)
		{
			if (collision.gameObject.CompareTag(targetTag) && collision.gameObject.GetComponent<EnemyHealthComponent>())
			{
				collision.gameObject.GetComponent<EnemyHealthComponent>().TakeDamage(damage);
				Invoke("Despawn", EnemyCollisionLifetime);
			}
	
			if (collision.gameObject.CompareTag("Environment"))
			{
				Invoke("Despawn", Lifetime);
			}
		}

		private void Despawn()
		{
			Destroy(gameObject);
		}


	}

}

