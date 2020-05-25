using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace UnityHelpers.CanvasHelpers
{
    public class ScrollbarButtons : MonoBehaviour
    {
        public Scrollbar scrollbar;
        public Button decreaseButton, increaseButton;
        public float speed = 0.5f;

        private bool isDecreaseButtonPressed = false, isIncreaseButtonPressed = false;

        private void Start()
        {
            SetDecreaseButtonEventTrigger();
            SetIncreaseButtonEventTrigger();
        }

        private void Update()
        {
            if (isDecreaseButtonPressed)
                scrollbar.value -= Time.deltaTime * speed;
            if (isIncreaseButtonPressed)
                scrollbar.value += Time.deltaTime * speed;
        }

        private void SetDecreaseButtonEventTrigger()
        {
            EventTrigger.Entry decreasePointerDown = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerDown
            };
            EventTrigger.Entry decreasePointerUp = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerUp
            };
            decreasePointerDown.callback.AddListener((eventData) => isDecreaseButtonPressed = true);
            decreasePointerUp.callback.AddListener((eventData) => isDecreaseButtonPressed = false);

            var decreaseButtonEventTrigger = decreaseButton.gameObject.AddComponent<EventTrigger>();
            decreaseButtonEventTrigger.triggers.Add(decreasePointerDown);
            decreaseButtonEventTrigger.triggers.Add(decreasePointerUp);
        }

        private void SetIncreaseButtonEventTrigger()
        {
            EventTrigger.Entry increasePointerDown = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerDown
            };
            EventTrigger.Entry increasePointerUp = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerUp
            };
            increasePointerDown.callback.AddListener((eventData) => isIncreaseButtonPressed = true);
            increasePointerUp.callback.AddListener((eventData) => isIncreaseButtonPressed = false);
            
            var increaseButtonEventTrigger = increaseButton.gameObject.AddComponent<EventTrigger>();
            increaseButtonEventTrigger.triggers.Add(increasePointerDown);
            increaseButtonEventTrigger.triggers.Add(increasePointerUp);
        }
    }
}