using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Haywire.Systems
{
	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class ExitApplication : MonoBehaviour
	{
		public List<AudioSource> ButtonSounds;
	
		public void OnClick()
		{
			int audioIndex = Random.Range(0, ButtonSounds.Count);
			ButtonSounds[audioIndex].Play();
			Application.Quit();
		}
	}
}
