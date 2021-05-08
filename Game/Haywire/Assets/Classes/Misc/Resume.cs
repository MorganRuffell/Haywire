using Haywire.Singletons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Gameplay
{
	public class Resume : MonoBehaviour
	{
		private GameManagerComponent gameManager;

		public List<AudioSource> ButtonSounds;

		public void ResumeGame()
		{
			if (gameManager.Turn_Sound_off_OnPause == true)
			{
				gameManager.GlobalMusicComponent.CheckSpawnState();
				gameManager.GameplayCanvas.SetActive(true);
				Time.timeScale = 1;
				gameManager.PauseCanvas.SetActive(false);
				gameManager.IsGamePaused = false;
			}
			else
			{
				gameManager.GameplayCanvas.SetActive(true);
				Time.timeScale = 1;
				gameManager.PauseCanvas.SetActive(false);
				gameManager.IsGamePaused = false;
			}
		}
	}
}

