using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Haywire.Character
{

	public class CharacterScoreComponent : MonoBehaviour
	{
		public Int16 PlayerScore;

		private void Awake()
		{
			PlayerScore = 0;
		}

		public void AddToPlayerScore(Int16 Amount)
		{
			PlayerScore += Amount;
		}
	}
}
