using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Haywire.Systems
{
	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class SceneSwapWithSound : MonoBehaviour
	{
		public string SceneToLoad;

		public List<AudioSource> Audio;

		public void OnClick()
		{
			SceneManager.LoadScene(SceneToLoad);
		}
	}
}

