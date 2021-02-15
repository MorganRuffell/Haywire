//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Character;

namespace Haywire.Singletons
{
	public class GameManagerComponent : MonoBehaviour
	{
		//This is a static object reference it exists for the entire program lifetime. Regardless of state changes
		public static GameManagerComponent GameManager;

		public CharacterScoreComponent characterScoreComponent;

		public Int32 PlayerScore;

		void Start()
		{
			GameManagerEnforce();

			PlayerScore = characterScoreComponent.PlayerScore;
		}

		//Enforces the singleton design pattern for the GameManager
		void GameManagerEnforce()
		{
			if (GameManager == null)
			{
				DontDestroyOnLoad(this);
				GameManager = this;
			}
			else if (GameManager != this)
			{
				Destroy(gameObject);
			}
		}

		// Update is called once per frame
		void Update()
		{
			PlayerScore = characterScoreComponent.PlayerScore;

		}
	}

}
