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

		public void Awake()
		{
			_CameraOffset = transform.position - Player.transform.position;
		}

		public void LateUpdate()
		{
			HandleAiming();

			transform.position = Player.transform.position + _CameraOffset;
		}

		private void HandleAiming()
		{
			
		}
	}

}

