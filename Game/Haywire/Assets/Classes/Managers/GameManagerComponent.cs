//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Haywire.Character;
using Haywire.UI;

namespace Haywire.Singletons
{
	public class GameManagerComponent : MonoBehaviour
	{
		//This is a static object reference it exists for the entire program lifetime. Regardless of state changes
		public static GameManagerComponent GameManager;
		public CharacterScoreComponent characterScoreComponent;
		public static FadeToBlack Ending;

		[Header("Pause Canvas")]
		public GameObject PauseCanvas;
		public GameObject GameplayCanvas;


		[HideInInspector]
		public bool IsAlive = true;

		[HideInInspector]
		public bool IsGamePaused = false;

		[HideInInspector]
		public bool IsCleanupDone;

		[Space]
		[Space]

		public Int32 PlayerScore;

		public Int16 AmmoAmount;
		public string GameOverScene;

		private void Awake()
		{
			GameManagerEnforce();
			PlayerScore = characterScoreComponent.PlayerScore;
			IsGamePaused = false;
		}

		void Start()
		{
			PauseCanvas.SetActive(false);
			GameplayCanvas.SetActive(true);
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

			if (IsAlive == false)
			{
				Debug.Log("I am dead.");

				Finale();
				///Ending.Call();
			}
		}

		public void PauseGame()
		{
			GameplayCanvas.SetActive(false);
			Time.timeScale = 0;

			PauseCanvas.SetActive(true);
			IsGamePaused = true;
		}
		public void ResumeGame()
		{
			GameplayCanvas.SetActive(true);
			Time.timeScale = 1;

			PauseCanvas.SetActive(false);
			IsGamePaused = false;
		}

		void Finale()
		{
			SceneManager.LoadScene(GameOverScene);
		}

	}

}
