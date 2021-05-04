using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.AI
{
	[RequireComponent(typeof(LeopardChaseComponent))]
	public class LeopardFiringComponent : MonoBehaviour
	{
		public float FireRate = 2.0f;
	
		[Header("Projectile Objects")]
		public List<GameObject> ProjectileObjects;

		[Header("Enemy Damage Control fields")]
		public int UpperDamage;
		public int LowerDamage;

		public string TargetTag;

		private LeopardChaseComponent leopardChaseComponent;

		private System.Random random = new System.Random();


		public void Awake()
		{
			leopardChaseComponent = gameObject.GetComponent<LeopardChaseComponent>();
		}


		public void FireProjectile()
		{
			if (ProjectileObjects != null)
			{
				var selectedfiringindex = random.Next(0, ProjectileObjects.Count);

				for (int i = 0; i <= ProjectileObjects.Count; i++)
				{
					if (i == selectedfiringindex)
					{
						//Ensure that the projectiles have a damage index
						Instantiate(ProjectileObjects[i]);
					}
					
				}
			}
			else
			{
				Debug.Log("There are no elements in the list, please add some in.");
			}
		}
	}
}
