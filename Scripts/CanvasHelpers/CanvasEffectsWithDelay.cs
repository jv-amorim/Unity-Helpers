using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UnityHelpers.CanvasHelpers
{
	public class CanvasEffectsWithDelay : MonoBehaviour
	{
		public void DestroyCanvasGameObject(GameObject objectToDestroy, float delayInSeconds)
		{
		    StartCoroutine(DestroyCanvasGameObject_Helper(objectToDestroy, delayInSeconds));
		}

		private IEnumerator DestroyCanvasGameObject_Helper(GameObject objectToDestroy, float delayInSeconds)
		{
		    yield return new WaitForSeconds(delayInSeconds);

		    Destroy(objectToDestroy);
		}

		public void FadeOut(Image imageToFadeOut, float delayToStart, float durationInSeconds)
		{
		    StartCoroutine(FadeOut_Helper(imageToFadeOut, delayToStart, durationInSeconds));
		}

		private IEnumerator FadeOut_Helper(Image imageToFadeOut, float delayToStart, float durationInSeconds)
		{
		    yield return new WaitForSeconds(delayToStart);

		    imageToFadeOut.CrossFadeAlpha(0f, durationInSeconds, false);
		}
	}
}