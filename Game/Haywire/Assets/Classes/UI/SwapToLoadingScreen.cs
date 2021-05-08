using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Haywire.Systems
{

	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class SwapToLoadingScreen : MonoBehaviour
	{
		public List<string> Scenes;

		public List<AudioSource> audios;

		public void OnClick()
		{
			int sceneindex = Random.Range(0, Scenes.Count);

			SceneManager.LoadScene(Scenes[sceneindex].ToString());
		}
	}
}
