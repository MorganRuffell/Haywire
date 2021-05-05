//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Haywire.UI
{
	public class UI_HealthBar : MonoBehaviour
	{
		public Image HealthBar;

		public float LerpSpeed;

		public CharacterHealthComponent _PlayerHealth;

		public void Awake()
		{

		}

		void LateUpdate()
		{
			HealthBar.fillAmount = Mathf.Lerp(HealthBar.fillAmount, _PlayerHealth.UI_HealthPercentage(), Time.deltaTime * LerpSpeed);
		}
	}
}

