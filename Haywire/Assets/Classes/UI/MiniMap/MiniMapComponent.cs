using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.UI
{
	public class MiniMapComponent : MonoBehaviour
	{
		public static MiniMapComponent MiniMap;
		public Transform PlayerLocation;

		private void Start()
		{
			SingletonEnforce();
		}

		//Enforces the singleton design pattern for the GameManager
		void SingletonEnforce()
		{
			if (MiniMap == null)
			{
				DontDestroyOnLoad(this);
				MiniMap = this;
			}
			else if (MiniMap != this)
			{
				Destroy(gameObject);
			}
		}
		void LateUpdate()
		{
			//ToDo: Debug this.
			//	- The camera does not translate.

			Vector3 newPosition = PlayerLocation.position;
			newPosition.y = transform.position.y;
			transform.position = newPosition;

			transform.rotation = Quaternion.Euler(90.0f, PlayerLocation.eulerAngles.y, 0.0f);

		}
	}
}


