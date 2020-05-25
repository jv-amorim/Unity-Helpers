using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace UnityHelpers.TextureHelpers
{
    public class TextureLoader : MonoBehaviour
    {
        public Texture errorDefaultTexture;

		/// <summary>Sets the raw image texture with a texture from a local image file or from a web image file.</summary>
        public IEnumerator SetRawImageWithTextureFromRequest(string imageFullPath, RawImage rawImage)
        {
            using (UnityWebRequest requester = UnityWebRequestTexture.GetTexture(imageFullPath))
            {
                yield return requester.SendWebRequest();
                Texture loadedTexture = DownloadHandlerTexture.GetContent(requester);

                if (loadedTexture == null)
                    rawImage.texture = errorDefaultTexture;
                else
                    rawImage.texture = loadedTexture;
            }
        }

		/// <summary>Gets the texture of a local image file.</summary>
        public Texture GetTextureFromFile(string imageFullPath)
        {
            try
            {
                byte[] imageData = File.ReadAllBytes(imageFullPath);
                Texture2D texture = new Texture2D(2048, 2048);
                texture.LoadImage(imageData);
                return texture as Texture;
            }
            catch
            {
                return errorDefaultTexture;
            }
        }
    }
}