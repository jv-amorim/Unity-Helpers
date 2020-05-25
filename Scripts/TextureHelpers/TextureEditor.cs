using UnityEngine;

namespace UnityHelpers.TextureHelpers
{
    public static class TextureEditor
    {
        public static Texture2D CropTexture(Texture2D texture, int startingPixelX, int startingPixelY, int resultingWidth, int resultingHeight)
        {
            Color[] pixels = texture.GetPixels(startingPixelX, startingPixelY, resultingWidth, resultingHeight);

            Texture2D newTexture = new Texture2D(resultingWidth, resultingHeight);
            newTexture.SetPixels(pixels);
            newTexture.Apply();

            return newTexture;
        }
    }
}