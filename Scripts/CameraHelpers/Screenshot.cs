using UnityEngine;

namespace UnityHelpers.CameraHelpers
{
    [RequireComponent(typeof(Camera))]
    public class Screenshot : MonoBehaviour
    {
        private const int ScreenshotBaseWidth = 1024;
        private const int ScreenshotBaseHeight = 1024;

        public Texture2D LastScreenshotTaken { get; private set; }

        public void TakeScreenshot()
        {
            var camera = gameObject.GetComponent<Camera>();

            RenderTexture renderTexture = new RenderTexture(ScreenshotBaseWidth, ScreenshotBaseHeight, 24);
            camera.targetTexture = renderTexture;
            Texture2D screenshot = new Texture2D(ScreenshotBaseWidth, ScreenshotBaseHeight, TextureFormat.RGB24, false);
            camera.Render();

            RenderTexture.active = renderTexture;
            screenshot.ReadPixels(new Rect(0, 0, ScreenshotBaseWidth, ScreenshotBaseHeight), 0, 0);
            camera.targetTexture = null;

            RenderTexture.active = null;
            Destroy(renderTexture);

            LastScreenshotTaken = screenshot;
        }
    }
}