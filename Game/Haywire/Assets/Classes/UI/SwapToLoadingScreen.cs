using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Haywire.Systems
{
	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class SwapToLoadingScreen : MonoBehaviour, ISoundSystem
	{
		public List<string> Scenes;

		public List<AudioSource> audios;

		public void OnClick()
		{
			int sceneindex = UnityEngine.Random.Range(0, Scenes.Count);
			PlayGameSounds(audios);
			SceneManager.LoadScene(Scenes[sceneindex].ToString());
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
