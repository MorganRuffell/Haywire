/////////////////////////////////////////////////////////////////////////////////
////
////    Unnamed Project, Ruffell Interactive (c)
////     
////	Programmer: Morgan Ruffell
////	
//////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Gameplay;
using System.Threading;

namespace Haywire.Audio
{
	public class GlobalMusicController : MonoBehaviour, ISoundSystem
	{
		Thread GlobalAudioThread;

		public WaveSpawner LocalWaveSpawnerComponent;

		[Header("Global Game Audio")]
		#region AudioSources
		public List<AudioSource> GameplayMusic;
		public List<AudioSource> WaitingMusic;
		public List<AudioSource> CountingMusic;
		public List<AudioSource> SpawningMusic;
		#endregion

		//On awake get the WaveSpawner and the GameManager
		void Awake()
		{
			GlobalAudioThread = new Thread(CheckSpawnState);
			GlobalAudioThread.Start();
		}

		void Start()
		{
			StopAllGameSounds(GameplayMusic, WaitingMusic, CountingMusic, SpawningMusic);
		}

		private void CheckSpawnState()
		{
			switch (LocalWaveSpawnerComponent.WaveSpawnState)
			{
				case SpawnState.INSTANTIATING:
					GlobalAudioThread.Abort(GlobalAudioThread);
					PlayInstantiatingMusic(SpawningMusic);
					break;
				case SpawnState.WAITING:
					GlobalAudioThread.Abort(GlobalAudioThread);
					PlayWaitingMusic(WaitingMusic);
					break;
				case SpawnState.COUNTING:
					GlobalAudioThread.Abort(GlobalAudioThread);
					PlayCountingMusic(CountingMusic);
					break;
				case SpawnState.ERROR:
					PlayErrorMusic();
					break;
				default:
					break;
			}
		}

		#region PlaySounds


		private void PlayInstantiatingMusic(List<AudioSource> SpawningMusic)
		{
			for (int index = 0; index <= SpawningMusic.Count; index++)
			{
				if (SpawningMusic[index].isPlaying == true)
				{
					return;
				}
				else
				{
					PlayGameSounds(SpawningMusic);
				}

			}
		}

		private void PlayWaitingMusic(List<AudioSource> WaitingMusic)
		{
			for (int index = 0; index <= WaitingMusic.Count; index++)
			{
				if (WaitingMusic[index].isPlaying == true)
				{
					return;
				}
				else
				{
					PlayGameSounds(WaitingMusic);
				}

			}
		}

		private void PlayCountingMusic(List<AudioSource> CountingMusic)
		{
			for (int index = 0; index <= CountingMusic.Count; index++)
			{
				if (CountingMusic[index].isPlaying == true)
				{
					return;
				}
				else
				{
					PlayGameSounds(CountingMusic);
				}
			}
		}

		private void PlayErrorMusic()
		{
			Debug.LogError("The Wavespawner is in an error state.");
		}


		#endregion

		//private void StopAllGameSounds(List<AudioSource> SoundList0, List<AudioSource> SoundList1, List<AudioSource> SoundList2, List<AudioSource> SoundList3)
		//{
		//	if (SoundList0.Count > 1 || SoundList1.Count > 1 || SoundList2.Count > 1 || SoundList3.Count > 1)
		//	{
		//		var TotalAmountofGameplayMusic = SoundList0.Count + SoundList1.Count + SoundList2.Count + SoundList3.Count;

		//		for (int index = 0; index == TotalAmountofGameplayMusic;)
		//		{
		//			for() 


		//			foreach (AudioSource audioSource in SoundList0)
		//			{
		//				if (SoundList0[index].isPlaying == true)
		//				{
		//					SoundList0[index].Stop();
		//				}
		//			}

		//			foreach (AudioSource audioSource in SoundList1)
		//			{
		//				if (SoundList1[index].isPlaying == true)
		//				{
		//					SoundList1[index].Stop();
		//				}
		//			}

		//			foreach (AudioSource audioSource in SoundList2)
		//			{
		//				if (SoundList2[index].isPlaying == true)
		//				{
		//					SoundList2[index].Stop();
		//				}
		//			}

		//			foreach (AudioSource audioSource in SoundList3)
		//			{
		//				if (SoundList3[index].isPlaying == true)
		//				{
		//					SoundList3[index].Stop();
		//				}
		//			}

		//			index++;
		//		}

		//	}

		//}

		private void StopAllGameSounds(List<AudioSource> SoundList0, List<AudioSource> SoundList1, List<AudioSource> SoundList2, List<AudioSource> SoundList3)
		{
			StopSounds(SoundList0);
			StopSounds(SoundList1);
			StopSounds(SoundList2);
			StopSounds(SoundList3);
		}

		private void StopSounds(List<AudioSource> list)
		{
			if (list.Count > 1)
			{
				foreach (AudioSource source in list)
				{
					if (source.isPlaying == true)
					{
						source.Stop();
					}
				}

				// Comparable to the foreach above
				//for (int i =0; i < list.Count; i++)
				//{
				//	AudioSource a = list[i];
				//	if (a.isPlaying == true)
				//	{
				//		a.Stop();
				//	}
				//}
			}
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
