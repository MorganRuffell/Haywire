using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Haywire.Systems
{
	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class RestartScene : MonoBehaviour
	{
		public string sceneToLoad;

		public List<AudioSource> ButtonSounds;

		public void OnClick()
		{
			Scene scene = SceneManager.GetActiveScene(); 
			SceneManager.LoadScene(sceneToLoad);
			Time.timeScale = 1;
		}
	}
}
