using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Haywire.Systems
{
	[DisallowMultipleComponent, RequireComponent(typeof(Button))]
	public class SceneSwap : MonoBehaviour
	{
		public string SceneToLoad;

		public void OnClick()
		{
			SceneManager.LoadScene(SceneToLoad);
		}
	}
}
