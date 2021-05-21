//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Haywire.Character;

namespace Haywire.UI
{
	public class UI_HealthBar : MonoBehaviour
	{
		public Image HealthBar;

		public float LerpSpeed; 

		public CharacterHealthComponent _PlayerHealth;

		void LateUpdate()
		{
			HealthBar.fillAmount = Mathf.Lerp(HealthBar.fillAmount, _PlayerHealth.UI_HealthPercentage(), Time.deltaTime * LerpSpeed);
		}
	}
}

