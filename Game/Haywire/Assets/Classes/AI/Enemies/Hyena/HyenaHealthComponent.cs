//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.AI;

namespace Haywire.AI
{
	public class HyenaHealthComponent : EnemyHealthComponent
	{
		public int HyenaMaxHealth = 50;
		public int HyenaCurrentHealth;


		public new void Awake()
		{
			HyenaMaxHealth = HyenaCurrentHealth;
		}

		public new void TakeDamage(int Amount)
		{
			HyenaCurrentHealth =- Amount;
		}

	}

}
