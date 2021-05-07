//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////


using System;
using UnityEngine;
using UnityEngine.UI;
using Haywire.Singletons;
using System.Collections.Generic;

namespace Haywire.UI
{
	[RequireComponent(typeof(Text)), DisallowMultipleComponent]
	public class AmmoRemainingScript : MonoBehaviour
	{
		public GameManagerComponent GameManager;

		public Text AmmoText;

		public List<Color> AmmoRemainingColors;

		// Start is called before the first frame update
		void Start()
		{
			AmmoText = gameObject.GetComponent<Text>();
		}

		// Update is called once per frame
		void Update()
		{
			AmmoText.text = GameManager.AmmoAmount.ToString();

			//if (GameManager.AmmoAmount < 30)
			//{
			//	AmmoText = gameObject.GetComponent<Text>();

			//	if (GameManager.AmmoAmount < 1)
			//	{
			//		AmmoText.color = AmmoRemainingColors[0];
			//	}

			//	AmmoText.color = AmmoRemainingColors[1];
			//}
			//else
			//{
			//	AmmoText.color = AmmoRemainingColors[2];
			//}
		}
	}
}

