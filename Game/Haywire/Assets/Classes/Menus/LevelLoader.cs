//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Haywire.Systems
{
	public class LevelLoader : MonoBehaviour
	{
		[Header("Scene Index"), TooltipAttribute("This is the index of the scene we want to load.")]
		public int SceneIndex = 1;

		public List<GameObject> LoadingDots;

		private void Start()
		{
			LoadLevel(SceneIndex);
		}

		public void LoadLevel(int sceneIndex)
		{
			StartCoroutine(LoadSceneAsyncrounously(sceneIndex));
		}

		//Coroutines are not async, 
		public IEnumerator LoadSceneAsyncrounously(int SceneIndex)
		{
			Application.backgroundLoadingPriority = ThreadPriority.Low;

			AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

			while (!operation.isDone)
			{
				float progress = Mathf.Clamp01(operation.progress / 0.001f);

				if (progress > 0.01f)
				{
					LoadingDots[0].SetActive(true);
				}

				else if (progress > 0.1f)
				{
					LoadingDots[1].SetActive(true);
				}

				else if (progress > 0.7f)
				{
					LoadingDots[2].SetActive(true);
				}

				Debug.Log(operation.progress);
				yield return null;
			}
		}
	}
}


