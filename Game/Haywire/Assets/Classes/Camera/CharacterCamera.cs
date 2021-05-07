//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Systems
{
	public class CharacterCamera : MonoBehaviour, ISoundSystem
	{
		[Tooltip("PlayerLocation and player should be the same gameObject")]
		public GameObject Player;

		public bool IsAiming;

		public Vector3 _CameraOffset;

		public List<GameObject> Cameras;

		[Header("Zoom in and out sounds")]
		public List<AudioSource> ZoomInSounds;
		public List<AudioSource> ZoomOutSounds;


		public void Awake()
		{
			_CameraOffset = transform.position - Player.transform.position;
		}

		public void Update()
		{
			transform.position = Player.transform.position + _CameraOffset;

			if (Input.GetMouseButtonDown(1))
			{
				IsAiming = !IsAiming;
				Invoke("HandleAiming", 0.2f);
			}
		}

		private void HandleAiming()
		{
			if (Cameras[0].activeSelf)
			{
				Cameras[0].SetActive(false);
				PlayGameSounds(ZoomInSounds);
				Cameras[1].SetActive(true);
				return;
			}

			else if (Cameras[1].activeSelf)
			{
				Cameras[1].SetActive(false);
				PlayGameSounds(ZoomOutSounds);
				Cameras[0].SetActive(true);

				return;
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
				throw new Exception();
			}
		}

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			throw new System.NotImplementedException();
		}


	}

}

