using System;
using UnityEngine;
using UnityEngine.UI;
using Haywire.Singletons;

namespace Haywire.UI
{	
	[RequireComponent(typeof(Text))]
	public class AmmoRemainingScript : MonoBehaviour
	{
		public GameManagerComponent GameManager;

		public Int16 AmmoAmount = 10;

		public Text AmmoText;

		// Start is called before the first frame update
		void Start()
		{
			AmmoText = gameObject.GetComponent<Text>();
		}

		// Update is called once per frame
		void Update()
		{
			AmmoText.text = AmmoAmount.ToString();
		}
	}
}

