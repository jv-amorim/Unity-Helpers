using UnityEngine;
using UnityEngine.UI;

namespace UnityHelpers.CanvasHelpers
{
    public static class CanvasEffects
    {
        /// <summary>
        /// Create a new alert in Canvas with the prefab and duration (in seconds) passed as parameters.
        /// </summary>
        public static void Alert(GameObject alertPrefab, GameObject canvas, float durationInSeconds, bool clearAlertsCurrentlyDisplayed)
        {
            if (clearAlertsCurrentlyDisplayed)
            	ClearAllAlerts();

            GameObject alert = Object.Instantiate(alertPrefab, canvas.transform);

            Image alertImage = alert.GetComponent<Image>();
            if(alertImage == null)
            {
                alertImage = alert.AddComponent<Image>();
                alertImage.color = new Color(255, 0, 0);
            }

            alertImage.raycastTarget = false;

            var canvasEffectsWithDelay = alert.AddComponent<CanvasEffectsWithDelay>();
            canvasEffectsWithDelay.FadeOut(alertImage, 1f, 3f);
            canvasEffectsWithDelay.DestroyCanvasGameObject(alert, 4f);
        }

        public static void ClearAllAlerts()
        {
            GameObject[] alertsInScene = GameObject.FindGameObjectsWithTag("Alert");
            foreach (GameObject alert in alertsInScene)
                alert.SetActive(false);
        }
    }
}
