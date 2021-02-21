//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Singletons;
using UnityEngine;
using System;

namespace Haywire.Character
{
	[DisallowMultipleComponent, RequireComponent(typeof(CharacterMovementComponent))]
	public class CharacterControlComponent : MonoBehaviour
	{
		[Header("Character Controller")]
		public GameManagerComponent GameManager;

		public Int16 AmmoReloadThreshold;

		private void Update()
		{

			if (Input.GetKey(KeyCode.R) && GameManager.AmmoAmount < 10)
			{
				Debug.Log("Debug0");
				GameManager.AmmoAmount++;
			}
		}

	}
}
