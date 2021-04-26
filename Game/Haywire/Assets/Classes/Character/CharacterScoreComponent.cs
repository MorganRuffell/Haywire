//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
////	
//////////////////////////////////////////////////////////////////////////


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.UI;

namespace Haywire.Character
{
	public class CharacterScoreComponent : MonoBehaviour
	{
		[Header("Score UI Alpha Controller")]
		public UIAlphaControl alphaControl;
		public float ScoreUIApppearDuration = 1.0f;

		public Int16 PlayerScore;

		private void Awake()
		{
			PlayerScore = 0;
		}

		public void AddToPlayerScore(Int16 Amount)
		{
			alphaControl.Appear(ScoreUIApppearDuration);
			PlayerScore += Amount;
		}
	}
}
