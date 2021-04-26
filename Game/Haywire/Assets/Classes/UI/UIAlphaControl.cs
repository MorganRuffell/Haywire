using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		Fade(OnBeginPlay);
	}

	public void Fade(bool OnBeginPlay)
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
}
