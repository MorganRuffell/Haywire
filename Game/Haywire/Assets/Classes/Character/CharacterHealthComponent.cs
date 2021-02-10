//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
////	
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Character
{
	[RequireComponent(typeof(CharacterMovementComponent))]
	public class CharacterHealthComponent : MonoBehaviour
	{
		//Player Health Values
		public Int16 MaxHealth = 100;
		public Int16 CurrentHealth;

		private void Awake()
		{
			CurrentHealth = MaxHealth;
		}


		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			UI_HealthPercentage();

			if (CurrentHealth >= 0)
			{
				//If this goes below a value broadcast an event to the GameManager. 
				//Who in turn should broadcast that event to everything else, and call GameOver.

			}

		}

		public void TakeDamage(Int16 Amount)
		{
			CurrentHealth -= Amount;
		}

		public void Death()
		{
			//If player is dead (This is a bool on the GameManager.
			// and the player lives count is less than 0.

			//Invoke the lifecheck.

			//if the lives count is less than 0

			//Set that global var to be true.
			//Lock all rb constraints
			//Then Invoke the DestroyGameObject.
			//Unless we want to look at the corpse? 
		}

		public float UI_HealthPercentage()
		{
			return (float)CurrentHealth / MaxHealth;
		}

	}
}



