using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Haywire.Systems
{
	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class ExitApplication : MonoBehaviour
	{
		public void OnClick()
		{
			Application.Quit();
		}
	}
}
