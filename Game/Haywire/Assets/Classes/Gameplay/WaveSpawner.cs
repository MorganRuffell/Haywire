//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Gameplay;
using Haywire.Singletons;
using Haywire.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Gameplay
{
	public enum SpawnState
	{
		INSTANTIATING,
		WAITING,
		COUNTING, 
		ERROR
	};

	[System.Serializable]
	public class Wave
	{
		[Header("Wave information")]
		public string WaveName;
		public List<GameObject> Enemies;
		public int EnemyCount;
		public int Rate;
	}

	[RequireComponent(typeof(GameManagerComponent))]
	public class WaveSpawner : MonoBehaviour
	{
		[Header("Wave timings and delays")]
		[Tooltip("Time in second from when this object enters the scene to the first wave.")]
		public float StartDelay = 2.0f;
		public float DelayBetweenEnemyWaves = 6.0f;
		public float waveCountdown;
		public WaveUIComponent WaveUIController;

		public Wave[] waves;
		private int NextWave = 0;

		[Tooltip("GameObject wave spawn transform array, store each transform in this array")]
		public Transform[] spawnPoints;

		[HideInInspector, Header("Spawn States")]
		public SpawnState WaveSpawnState = SpawnState.COUNTING;
		private bool IsSpawnLocation0 = true;
		private float searchCountdown = 1.5f;

		private GameManagerComponent GameManager;

		void Start()
		{
			WaveUIController._WaveStartingUIComponent.SetActive(true);
			waveCountdown = DelayBetweenEnemyWaves;
		}

		void Update()
		{
			if (WaveSpawnState == SpawnState.WAITING)
			{
				WaveUIController._WaveStartingUIComponent.SetActive(false);

				if (!EnemiesAreStillAlive())
				{
					WaveCompleted();
					//Begin a new round. Increment wave count by 1. Notify player. Add points. Order pizza. Profit.
				} 	
				else
				{
					return;
				}
			}


			if (waveCountdown <= 0)
			{
				if (WaveSpawnState != SpawnState.INSTANTIATING)
				{
					WaveUIController._WaveStartingUIComponent.SetActive(false);
					StartCoroutine(SpawnWave(waves[NextWave]));
				}
			}
			else
			{
				waveCountdown -= Time.deltaTime;
			}
		}

		bool EnemiesAreStillAlive()
		{
			searchCountdown -= Time.deltaTime;
			if (searchCountdown <= 0.0f)
			{
				searchCountdown = 1.0f; 

				if(GameObject.FindGameObjectWithTag("Enemy") == null)
				{
					return false;
				}
				else
				{
					return true;
				}
			}

			return true;
		}

		IEnumerator SpawnWave(Wave _wave)
		{
			//Debug.Log("Spawning Wave" + _wave.WaveName);
			WaveSpawnState = SpawnState.INSTANTIATING;

			for (int index = 0; index < _wave.EnemyCount;)
			{
				SpawnEnemy(_wave.Enemies[0], _wave.Enemies[1]);
				index++;

				yield return new WaitForSeconds(2 / _wave.Rate);
			}

			WaveSpawnState = SpawnState.WAITING;

			yield break;
		}

		void SpawnEnemy(GameObject _enemy, GameObject _enemy1)
		{
			//Debug.Log("Spawning Enemy" + _enemy.name);

			AlternateSpawnLocation(_enemy, _enemy1);
		}

		private void AlternateSpawnLocation(GameObject _enemy, GameObject _enemy1)
		{
			if (IsSpawnLocation0 == false)
			{
				Instantiate(_enemy, spawnPoints[1].position, transform.rotation);
				IsSpawnLocation0 = true;
			}
			else
			{
				Instantiate(_enemy1, spawnPoints[0].position, transform.rotation);
				IsSpawnLocation0 = false;
				return;
			}
		}

		public void WaveCompleted()
		{
			Debug.Log("Wave Completed!");

			WaveSpawnState = SpawnState.COUNTING;
			waveCountdown = DelayBetweenEnemyWaves;

			NextWave++;

			if (NextWave >= 4)
			{
				Debug.Log("Level Completed!");

				GameManager.HasWon = true;

				//This is where we are going to transition to another scene...
				//Or end this bit of the game.
			}
		}
	}
}

