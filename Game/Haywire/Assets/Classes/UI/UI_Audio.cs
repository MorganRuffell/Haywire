using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Audio : MonoBehaviour, ISoundSystem
{
	public List<AudioSource> UIAudio;

	public void OnClick()
	{
		PlayGameSounds(UIAudio);
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
		throw new System.NotImplementedException();
	}
}
