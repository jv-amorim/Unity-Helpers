using UnityEngine;

namespace UnityHelpers.VirtualKeyboardHelpers
{
	public class VirtualKeyboardManager : MonoBehaviour
	{
		private VirtualKeyboard virtualKeyboard;

		public void Start() => virtualKeyboard = new VirtualKeyboard();

		public void OpenKeyboard()
		{
		    CloseKeyboard();
		    virtualKeyboard.ShowTouchKeyboard();
		}

		public void CloseKeyboard() => virtualKeyboard.HideTouchKeyboard();
	}
}