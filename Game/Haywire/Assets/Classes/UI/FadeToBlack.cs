using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Haywire.UI
{
	[DisallowMultipleComponent]
	public class FadeToBlack : MonoBehaviour
	{
		public GameObject blackOutSquare;

		public void Call()
		{
			StartCoroutine(FadeToBlackSquare(true));
		}
	
		public IEnumerator FadeToBlackSquare(bool fadeToBlack = true, int FadeSpeed = 5)
		{
			Color objectColour = blackOutSquare.GetComponent<Image>().color;
			float fadeAmount;
			
			if (fadeToBlack)
			{
				while (blackOutSquare.GetComponent<Image>().color.a < 1)
				{
					fadeAmount = objectColour.a + (FadeSpeed * Time.deltaTime);

					objectColour = new Color(objectColour.r, objectColour.g, objectColour.b, fadeAmount);
					blackOutSquare.GetComponent<Image>().color = objectColour;
					yield return null;

				}
			}
			else
			{
				while(blackOutSquare.GetComponent<Image>().color.a > 0)
				{
					fadeAmount = objectColour.a - (FadeSpeed * Time.deltaTime);

					objectColour = new Color(objectColour.r, objectColour.g, objectColour.b, fadeAmount);

					blackOutSquare.GetComponent<Image>().color = objectColour;

					yield return null;
				}

			}

			yield return new WaitForEndOfFrame();
		}
	}
}
