//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
////	
//////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.UI
{
	[RequireComponent(typeof(CanvasGroup))]
	public class UIAlphaControl : MonoBehaviour
	{
		[HideInInspector]
		public bool mFaded = false;

		[Header("Duration for fading out the UI")]
		public float Duration = 0.4f;
		public float BeginPlayDuration = 10.0f;

		private bool OnBeginPlay = true;

		public void Start()
		{
			//Fade(OnBeginPlay, BeginPlayDuration);
		}

		public void Fade(bool OnBeginPlay, float Duration)
		{
			if (OnBeginPlay)
			{
				OnBeginPlay = false;

				var canvasGroup = GetComponent<CanvasGroup>();

				StartCoroutine(DoFade(canvasGroup, canvasGroup.alpha, mFaded ? 1 : 0, BeginPlayDuration));

				mFaded = !mFaded;
			}
			else
			{
				var canvasGroup = GetComponent<CanvasGroup>();

				StartCoroutine(DoFade(canvasGroup, canvasGroup.alpha, mFaded ? 1 : 0, Duration));

				mFaded = !mFaded;
			}
		}

		public IEnumerator DoFade(CanvasGroup canvasGroup, float start, float end, float Duration)
		{
			var counter = 0.0f;

			while (counter < Duration)
			{
				counter += Time.deltaTime;

				canvasGroup.alpha = Mathf.Lerp(start, end, counter / Duration);

				yield return null;
			}
		}

		public IEnumerator DoAppear(CanvasGroup canvasGroup, float start, float end, float Duration)
		{
			var counter = 0.0f;

			while (counter < Duration)
			{
				counter = +Time.deltaTime;

				canvasGroup.alpha = Mathf.Lerp(start, end, counter / Duration);

				yield return null;
			}
		}

		public void Appear(float Duration)
		{
			var canvasGroup = GetComponent<CanvasGroup>();
			DoAppear(canvasGroup, canvasGroup.alpha, 1, Duration);

			mFaded = !mFaded;
		}
	}
}

