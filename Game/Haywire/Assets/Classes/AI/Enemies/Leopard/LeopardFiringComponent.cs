using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.AI
{
	[RequireComponent(typeof(LeopardChaseComponent))]
	public class LeopardFiringComponent : MonoBehaviour, ISoundSystem
	{

		[Header("Projectile Objects")]
		public List<GameObject> ProjectileObjects;

		[Header("Enemy Damage Control fields")]
		public int UpperDamage;
		public int LowerDamage;

		public string TargetTag;

		private LeopardChaseComponent leopardChaseComponent;

		private System.Random random = new System.Random();

		public List<AudioSource> LeopardFiringNoises;

		[Header("Firing System Data")]
		[Tooltip("A list of firing rates, emulates premature firing, some of these guys may be more egar than they'll admit!")]
		public List<float> FireRates;
		private float timer = 0.0f;
		private int selectedfiringindex;
		public Transform FiringLocation;

		private float FireRate;

		public void Awake()
		{
			selectedfiringindex = random.Next(0, ProjectileObjects.Count);
			random.Next(0, FireRates.Count);

			leopardChaseComponent = gameObject.GetComponent<LeopardChaseComponent>();
		}

		public void Update()
		{
			timer += Time.deltaTime;
		}

		public void FireProjectile()
		{
			if (timer < FireRate) return;

			if (ProjectileObjects != null)
			{
				//Ensure that the projectiles have a damage index
				timer = 0.0f;
				Instantiate(ProjectileObjects[selectedfiringindex],FiringLocation.position, FiringLocation.rotation);
			}
			else
			{
				Debug.Log("There are no elements in the list, please add some in.");
			}
		}

		public void PlayGameSounds(List<AudioSource> SoundList)
		{
			throw new System.NotImplementedException();
		}

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			throw new System.NotImplementedException();
		}
	}
}
