using System;
using Haywire.Singletons;
using UnityEngine;
using UnityEngine.UI;

namespace Haywire.UI
{
	public class ScoreScript : MonoBehaviour
	{
		public GameManagerComponent GameManager;

		[HideInInspector]
		public Int32 ScoreValue = 0;

		public Text ScoreText;

		private void Awake()
		{
			GameManager = GameObject.Find("GameManager").GetComponent<GameManagerComponent>();
		}

		// Start is called before the first frame update
		void Start()
		{
			ScoreText = gameObject.GetComponent<Text>();
			ScoreText.text = ScoreValue.ToString();
		}

		// Update is called once per frame
		void LateUpdate()
		{
			ScoreText.text = GameManager.PlayerScore.ToString();
		}
	}
}