using Haywire.Singletons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Haywire.Systems
{
	public class Pause : MonoBehaviour
	{
		private GameManagerComponent gameManager;

		[Header("Colors and Images")]
		public Image image;
		public Color[] colors;
	

		public void Awake()
		{
			gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerComponent>();
		}

		public void PauseClick()
		{
			if (gameManager.IsGamePaused == true)
			{
				gameManager.ResumeGame();
			}
			else
			{
				colors[1] = image.GetComponent<Image>().color;

				gameManager.PauseGame();

				image.GetComponent<Image>().color = colors[0];
			}
		}

		public void Update()
		{
			image.GetComponent<Image>().color = colors[1];
		}

	}
}
