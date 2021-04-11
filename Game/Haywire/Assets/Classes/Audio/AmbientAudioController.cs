//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Audio
{
	[RequireComponent(typeof(SphereCollider))]
	public class AmbientAudioController : MonoBehaviour
	{
		[Header("AmbientAudioSounds")]
		public List<AudioSource> AmbientAudioSources;

		private void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.tag == "Player")
			{
				PlayGameSounds(AmbientAudioSources);
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (other.gameObject.tag == "Player")
			{
				StopGameSounds(AmbientAudioSources);
			}
		}

		private void PlayGameSounds(List<AudioSource> SoundList)
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

		private void StopGameSounds(List<AudioSource> SoundList)
		{
			if (SoundList.Count < 1)
			{
				//Could be done in a foreach loop but felt that a traditional for loop would be better?
				for (int index = 0; index <= SoundList.Count; index++)
				{
					if (SoundList[index].isPlaying == true)
					{
						SoundList[index].Stop();
					}

				}

			}

		}

	}
}
