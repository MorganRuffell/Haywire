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
using Haywire.Audio;

namespace Haywire.Singletons
{
	public class GameManagerComponent : MonoBehaviour, ISoundSystem
	{
		//This is a static object reference it exists for the entire program lifetime. Regardless of state changes
		public static GameManagerComponent GameManager;
		public CharacterScoreComponent characterScoreComponent;
		public GlobalMusicController GlobalMusicComponent;
		public MouseManager mouseManager;
		[Header("The list of Alpha Controllers for the UI."), Tooltip("0. Health, 1. Score, 2. Automatic State, 3. Ammo")]
		public List<UIAlphaControl> AlphaControllers;

		public static FadeToBlack Ending;


		[Header("Pause Information")]
		public bool Turn_Sound_off_OnPause;
		public GameObject PauseCanvas;
		public GameObject GameplayCanvas;

		[Header("Audio")]
		public List<AudioSource> ScoreUpSound;


		[HideInInspector]
		public bool IsAlive = true;

	
		public bool HasWon = false;

		[HideInInspector]
		public bool IsGamePaused = false;

		[HideInInspector, SerializeField]
		public bool IsAiming = false;


		[HideInInspector]
		public bool IsCleanupDone;

		[Space]
		[Space]

		[Header ("Audio Playing objects in scene")]
		public Int32 PlayerScore;

		public float ScoreDelay;

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

		public void IncreaseScore(int Score)
		{
			if (Time.time - ScoreDelay > 1 / 1.0f)
			{
				PlayerScore = PlayerScore + Score / 100;
				PlayGameSounds(ScoreUpSound);
			}			
		}

		// Update is called once per frame
		void Update()
		{
			if (IsAlive == false)
			{
				Debug.Log("I am dead.");
				Finale();
			}
		
			if (HasWon && SceneManager.GetActiveScene().name != "WinScreen")
			{
				Scene scene = SceneManager.GetActiveScene();
				SceneManager.LoadScene("WinScreen");
				HasWon = false;
				//SceneManager.UnloadSceneAsync("Level1");
			}

		}
 
		public void PauseGame()
		{
			if (Turn_Sound_off_OnPause == true)
			{
				GlobalMusicComponent.StopAllGameSounds(GlobalMusicComponent.CountingMusic, GlobalMusicComponent.GameplayMusic, GlobalMusicComponent.SpawningMusic, GlobalMusicComponent.WaitingMusic);
				GameplayCanvas.SetActive(false);
				Time.timeScale = 0;
				PauseCanvas.SetActive(true);
				IsGamePaused = true;
			}
			else
			{
				GameplayCanvas.SetActive(false);
				Time.timeScale = 0;
				PauseCanvas.SetActive(true);
				IsGamePaused = true;
			}
		}

		public void ResumeGame()
		{
			if (Turn_Sound_off_OnPause == true)
			{
				GlobalMusicComponent.CheckSpawnState();
				GameplayCanvas.SetActive(true);
				Time.timeScale = 1;
				PauseCanvas.SetActive(false);
				IsGamePaused = false;
			}
			else
			{
				GameplayCanvas.SetActive(true);
				Time.timeScale = 1;
				PauseCanvas.SetActive(false);
				IsGamePaused = false;
			}
		}

		void Finale()
		{
			SceneManager.LoadScene(GameOverScene);
		}

		public void PlayGameSounds(List<AudioSource> SoundList)
		{
			if (SoundList.Count > 0)
			{
				var random = new System.Random();
				int SoundIndex = random.Next(SoundList.Count);

				SoundList[SoundIndex].Play();
			}
			else
			{
				Debug.LogWarning("Sound List is empty. This will need elements to play sounds.");
			}
		}

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			throw new NotImplementedException();
		}
	}

}
