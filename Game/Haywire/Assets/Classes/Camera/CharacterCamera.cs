//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Systems
{
	public class CharacterCamera : MonoBehaviour
	{
		[Tooltip("PlayerLocation and player should be the same gameObject")]
		public GameObject Player;

		public bool IsAiming;

		public Vector3 _CameraOffset;

		public List<GameObject> Cameras;

		public void Awake()
		{
			_CameraOffset = transform.position - Player.transform.position;
		}

		public void Update()
		{
			transform.position = Player.transform.position + _CameraOffset;

			if (Input.GetMouseButtonDown(1) || Input.GetMouseButton(1))
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
				Cameras[1].SetActive(true);
				return;
			}

			else if (Cameras[1].activeSelf)
			{
				Cameras[1].SetActive(false);
				Cameras[0].SetActive(true);

				return;
			}
			
		}

	}

}

