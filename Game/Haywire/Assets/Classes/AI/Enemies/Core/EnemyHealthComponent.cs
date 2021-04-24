//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.AI
{
	public abstract class EnemyHealthComponent : MonoBehaviour
	{
		public int Enemy_MaxHealth = 50;
		public int Enemy_CurrentHealth;

		public abstract void Awake();

		public abstract void TakeDamage(int Amount);
		
			//Enemy_CurrentHealth = Enemy_MaxHealth;
			//Enemy_CurrentHealth =- Amount;

		//You can create an implementation so that healthbars appear when health goes below 0. 
		//Write this in pseudocode, 
	}
}

