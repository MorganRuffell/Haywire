using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Haywire.Gameplay;


namespace Haywire.UI
{

	public class WaveUIComponent : MonoBehaviour
	{
		public static WaveUIComponent _WaveUIComponent;

		public WaveSpawner WaveSpawnerManager;

		[Header("Wavespawner UI Components")]
		public GameObject _WaveStartingUIComponent;

		void Awake()
		{
			SingletonEnforce();
		}

		void SingletonEnforce()
		{
			if (_WaveUIComponent == null)
			{
				DontDestroyOnLoad(this);
				_WaveUIComponent = this;
			}
			else if (_WaveUIComponent != this)
			{
				Destroy(gameObject);
			}
		}

		void FixedUpdate()
		{
			if (WaveSpawnerManager.waveCountdown < 8 && WaveSpawnerManager.waveCountdown != 0)
			{
				_WaveStartingUIComponent.SetActive(true);
			}
			else
			{
				_WaveStartingUIComponent.SetActive(false);

			}
		}
	}

}

