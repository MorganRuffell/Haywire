//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Singletons;
using Haywire.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Character
{
	[RequireComponent(typeof(CharacterHealthComponent)), DisallowMultipleComponent]
	public class CharacterFiringController : MonoBehaviour
	{
		[Header("Game Manager Component")]
		public GameManagerComponent GameManager;


		[Header("Character Firing Attributes")]
		[Tooltip("This is the place that bullet GameObjects instantiate from")]
		public Transform spawnPoint;

		public float FireRate = 1.0f;
		public float timer = 0.0f;


		[Space]
		public GameObject projectile;
		public GameObject AmmoUI;

		private void Update()
		{
			timer += Time.deltaTime;
			
			if (MouseManager._CanFire == true)
			{
				Debug.ClearDeveloperConsole();
				Fire();
			}
		}


		private void Fire()
		{
			if (Input.GetMouseButtonDown(0))
			{

				if (timer < FireRate) return;
				timer = 0.0f;

				if (GameManager.AmmoAmount <= 0)
				{ 
					Debug.ClearDeveloperConsole();
					Debug.Log("Out of Ammo");
					return;
				}

				else
				{
					GameManager.AmmoAmount--;
					Instantiate(projectile, spawnPoint.transform.position, spawnPoint.rotation);
				}

			}

		}

	}

}


