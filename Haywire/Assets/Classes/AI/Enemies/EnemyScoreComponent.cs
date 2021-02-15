//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Character;
using System;
using UnityEngine;

namespace Haywire.AI
{
	[RequireComponent(typeof(NavMeshControllerComponent))]
	[RequireComponent(typeof(EnemyHealthComponent))]
	public class EnemyScoreComponent : MonoBehaviour
	{
		public Int16 ScoreMultiplier = 1;

		public Int16 ScoreValue;

		private void OnDestroy()
		{
			ScoreValue = (short) (ScoreValue * ScoreMultiplier);

			GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterScoreComponent>().AddToPlayerScore(ScoreValue);
		}

	}
}
