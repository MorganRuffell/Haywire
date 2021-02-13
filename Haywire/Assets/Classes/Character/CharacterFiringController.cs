using Haywire.Singletons;
using Haywire.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Character
{
	[RequireComponent(typeof(CharacterHealthComponent))]
	public class CharacterFiringController : MonoBehaviour
	{
		[Header("Character Firing Attributes")]
		[Tooltip("This is the place that bullet GameObjects instantiate from")]
		public Transform spawnPoint;

		[Space]

		public GameObject projectile;

		public GameObject AmmoUI;

		public void Awake()
		{
			
		}

		public void Start()
		{
			
		}

		private void Update()
		{
			if (MouseManager._CanFire == true)
			{
				Debug.ClearDeveloperConsole();
				Debug.Log("Game Manager processed firing manager");
				Fire();
			}
		}


		private void Fire()
		{
			if (Input.GetMouseButtonDown(0))
			{
				if (AmmoUI.GetComponent<AmmoRemainingScript>().AmmoAmount <= 0)
				{ 
					Debug.ClearDeveloperConsole();
					Debug.Log("Out of Ammo");
					return;
				}

				else
				{
					AmmoUI.GetComponent<AmmoRemainingScript>().AmmoAmount--;
					Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
				}

			}

		}

	}

}


