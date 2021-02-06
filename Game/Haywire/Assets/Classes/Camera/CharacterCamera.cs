//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Camera
{
	public class CharacterCamera : MonoBehaviour
	{
		public Transform PlayerLocation;

		private Vector3 _CameraOffset;

		[Header("Orbit Camera Controls")]
		[Range(0.1f, 1.0f)]
		public float SmoothFactor = 0.5f;
		public bool LookatPlayer = false;

		public bool CanOrbitAroundPlayer = true;
		public float RotationSpeed = 5.0f;


		public void Awake()
		{
			_CameraOffset = transform.position - PlayerLocation.position;
		}

		public void LateUpdate()
		{
			if (CanOrbitAroundPlayer)
			{
				Quaternion cameraTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);
				_CameraOffset = cameraTurnAngle * _CameraOffset;
			}

			Vector3 finalPosition = PlayerLocation.position + _CameraOffset;

			transform.position = Vector3.Slerp(transform.position, finalPosition, SmoothFactor);

			if (LookatPlayer || CanOrbitAroundPlayer)
			{
				transform.LookAt(PlayerLocation);
			}
		}
	}

}

