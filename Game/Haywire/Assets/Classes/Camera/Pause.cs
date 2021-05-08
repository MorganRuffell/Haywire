using Haywire.Singletons;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Haywire.Systems
{
	public class Pause : MonoBehaviour, ISoundSystem
	{
		private GameManagerComponent gameManager;

		[Header("Colors and Images")]
		public Image image;
		public Color[] colors;

		[Header("Sounds")]
		public List<AudioSource> PauseSounds;

		public void Awake()
		{
			gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerComponent>();
		}

		public void PauseClick()
		{
			if (gameManager.IsGamePaused == true)
			{
				gameManager.ResumeGame();
			}
			else
			{
				colors[1] = image.GetComponent<Image>().color;

				gameManager.PauseGame();

				image.GetComponent<Image>().color = colors[0];
			}
		}

		public void Update()
		{
			image.GetComponent<Image>().color = colors[1];
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
				throw new Exception();
			}
		}

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			throw new System.NotImplementedException();
		}
	}
}



