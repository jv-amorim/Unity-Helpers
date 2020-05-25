using System.Collections;
﻿using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UnityHelpers.CanvasHelpers
{
    public class InputFieldHelpers : MonoBehaviour
    {
        public void ShowPasswordFieldContent(TMP_InputField passwordField)
        {
            passwordField.contentType = TMP_InputField.ContentType.Standard;
            passwordField.enabled = false;
            passwordField.enabled = true;
        }

        public void ShowPasswordFieldContent(InputField passwordField)
        {
            passwordField.contentType = InputField.ContentType.Standard;
            passwordField.enabled = false;
            passwordField.enabled = true;
        }

        public void HidePasswordFieldContent(TMP_InputField passwordField)
        {
            passwordField.contentType = TMP_InputField.ContentType.Password;
            passwordField.enabled = false;
            passwordField.enabled = true;
        }

        public void HidePasswordFieldContent(InputField passwordField)
        {
            passwordField.contentType = InputField.ContentType.Password;
            passwordField.enabled = false;
            passwordField.enabled = true;
        }

        public static IEnumerator ShowTemporaryMessage(TMP_InputField inputField, string message, float displayTime)
        {
            inputField.text = message;
            yield return new WaitForSeconds(displayTime);
            inputField.text = "";
        }
    }
}