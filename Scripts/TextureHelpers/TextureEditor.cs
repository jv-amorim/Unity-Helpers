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
        
        Texture2D RotateTexture(Texture2D originalTexture, bool clockwise)
        {
            Color32[] original = originalTexture.GetPixels32();
            Color32[] rotated = new Color32[original.Length];
            int w = originalTexture.width;
            int h = originalTexture.height;

            int iRotated, iOriginal;

            for (int j = 0; j < h; ++j)
            {
                for (int i = 0; i < w; ++i)
                {
                    iRotated = (i + 1) * h - j - 1;
                    iOriginal = clockwise ? original.Length - 1 - (j * w + i) : j * w + i;
                    rotated[iRotated] = original[iOriginal];
                }
            }

            Texture2D rotatedTexture = new Texture2D(h, w);
            rotatedTexture.SetPixels32(rotated);
            rotatedTexture.Apply();
            return rotatedTexture;
        }
    }
}
