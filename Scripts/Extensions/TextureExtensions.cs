using System;
using UnityEngine;

public static class TextureExtensions
{
    public static Texture2D MergeTextures(this Texture2D backTexture, Texture2D frontTexture)
    {
        if (backTexture.width != frontTexture.width || backTexture.height != frontTexture.height)
            throw new InvalidOperationException("Texture merging only works with two equal sized images!");

        var backTextureData = backTexture.GetPixels();
        var frontTextureData = frontTexture.GetPixels();

        int length = backTextureData.Length;
        var newTextureData = new Color[length];

        for (int i = 0; i < length; i++)
        {
            Color B = backTextureData[i];
            Color F = frontTextureData[i];

            float srcF = F.a;
            float destF = 1f - F.a;
            float alpha = srcF + destF * B.a;

            Color N = (F * srcF + B * B.a * destF) / alpha;
            N.a = alpha;

            newTextureData[i] = N;
        }

        var newTexture = new Texture2D(frontTexture.width, frontTexture.height);
        newTexture.SetPixels(newTextureData);
        newTexture.Apply();

        return newTexture;
    }

    public static Texture2D AddWatermark(this Texture2D background, Texture2D watermark, int startX, int startY)
    {
        Texture2D newTex = new Texture2D(background.width, background.height, background.format, false);
        for (int x = 0; x < background.width; x++)
        {
            for (int y = 0; y < background.height; y++)
            {
                if (x >= startX && y >= startY && x < watermark.width && y < watermark.height)
                {
                    Color bgColor = background.GetPixel(x, y);
                    Color wmColor = watermark.GetPixel(x - startX, y - startY);

                    Color final_color = Color.Lerp(bgColor, wmColor, wmColor.a / 1.0f);

                    newTex.SetPixel(x, y, final_color);
                }
                else
                    newTex.SetPixel(x, y, background.GetPixel(x, y));
            }
        }
        newTex.Apply();
        return newTex;
    }

    public static Texture2D ToTexture2D(this Texture textureToConvert)
    {
        Texture2D texture2D = new Texture2D(textureToConvert.width, textureToConvert.height, TextureFormat.RGBA32, false);

        RenderTexture renderTexture = new RenderTexture(textureToConvert.width, textureToConvert.height, 32);
        Graphics.Blit(textureToConvert, renderTexture);

        texture2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture2D.Apply();

        return texture2D;
    }
}