//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////


using System;
using UnityEngine;
using UnityEngine.UI;
using Haywire.Singletons;

namespace Haywire.UI
{	
	[RequireComponent(typeof(Text)), DisallowMultipleComponent]
	public class AmmoRemainingScript : MonoBehaviour
	{
		public GameManagerComponent GameManager;

		public Text AmmoText;

		// Start is called before the first frame update
		void Start()
		{
			AmmoText = gameObject.GetComponent<Text>();
		}

		// Update is called once per frame
		void Update()
		{
			AmmoText.text = GameManager.AmmoAmount.ToString();
		}
	}
}

