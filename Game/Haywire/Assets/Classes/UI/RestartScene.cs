using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Haywire.Systems
{
	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class RestartScene : MonoBehaviour, ISoundSystem
	{
		public string sceneToLoad;

		public List<AudioSource> ButtonSounds;

		public void OnClick()
		{
			PlayGameSounds(ButtonSounds);
			Scene scene = SceneManager.GetActiveScene(); 
			SceneManager.LoadScene(sceneToLoad);
			Time.timeScale = 1;
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
