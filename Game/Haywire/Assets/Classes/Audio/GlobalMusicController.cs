/////////////////////////////////////////////////////////////////////////////////
////
////    Unnamed Project, Ruffell Interactive (c)
////     
////	Programmer: Morgan Ruffell
////	
//////////////////////////////////////////////////////////////////////////////////

using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Singletons;
using Haywire.Gameplay;

namespace Haywire.Audio
{
	public class GlobalMusicController : MonoBehaviour, ISoundSystem
	{
		Thread GlobalAudioThread;

		public GameManagerComponent gameManager;

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

		void Update()
		{
			if (gameManager.IsGamePaused == true) { return; }
			else
			{
				CheckSpawnState();
			}
		}

		public void CheckSpawnState()
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

		public void StopAllGameSounds(List<AudioSource> SoundList0, List<AudioSource> SoundList1, List<AudioSource> SoundList2, List<AudioSource> SoundList3)
		{
			List<List<AudioSource>> LocalList = new List<List<AudioSource>>();

			LocalList.Add(SoundList0);
			LocalList.Add(SoundList1);
			LocalList.Add(SoundList2);
			LocalList.Add(SoundList3);


			//Collect all of the sounds passed into the method, add them to a list and then stop all of them.

			StopSounds(SoundList0);
			StopSounds(SoundList1);
			StopSounds(SoundList2);
			StopSounds(SoundList3);
		}

		public void StopSounds(List<AudioSource> list)
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
