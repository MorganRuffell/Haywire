using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.Singletons;
using Unity.Mathematics;
using System;

namespace Haywire.Gameplay
{
	public class FirearmControlComponent : MonoBehaviour
	{
		public ParticleSystem FiringParticles;
		public GameObject ParticleSystemLocation;
		public GameObject FirearmLight;


		public float4 rotation;

		public Animator PlayerAnimator;

		private Vector3 BasePosition = new Vector3();
		private Vector3 FiringPosition = new Vector3();
		private Vector3 GunSize = new Vector3();


		private quaternion FiringRotation = new quaternion();

		private void Start()
		{
			BasePosition = gameObject.transform.localPosition;

			SetupLocation();
		}

		private void SetupLocation()
		{
			//FiringPosition.x = 0.143f;
			//FiringPosition.y = 0.033f;
			//FiringPosition.z = 0.14f;

			FiringPosition.Set(0.022f, -0.0012f, -0.077f);
			GunSize.Set(0.62f,0.62f,0.62f);
			//FiringRotation.value = rotation;  //(188f, 115f, -148f);

		}

		private void Update()
		{
			if (PlayerAnimator.GetBool("CanFire").Equals(true) && PlayerAnimator.GetBool("IsIdle").Equals(false))
			{
				gameObject.transform.localPosition = FiringPosition;
				gameObject.transform.localScale = GunSize;
			}
			else
			{
				gameObject.transform.localPosition = BasePosition;

			}
		}

	}
}

