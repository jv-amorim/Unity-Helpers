using UnityEngine;

namespace UnityHelpers.CanvasHelpers
{
	/* To use this class and change the mouse cursor from arrow icon to link icon when hovering an element in canvas (a button, 
	   for example), you must attach this script to a GameObject and assign the arrow texture and link texture to the two public 
	   fields. The methods ChangeCursorToArrow() and ChangeCursorToLink() can be called with a EventTrigger, using the OnPointerEnter
	   and OnPointerExit events. */

    public class CursorEffects : MonoBehaviour
    {
        public Texture2D arrowCursor, linkCursor;
        private readonly CursorMode cursorMode = CursorMode.Auto;
        private readonly Vector2 hotSpot = Vector2.zero;

        public void ChangeCursorToArrow() => Cursor.SetCursor(arrowCursor, hotSpot, cursorMode);

        public void ChangeCursorToLink() => Cursor.SetCursor(linkCursor, hotSpot, cursorMode);
    }
}