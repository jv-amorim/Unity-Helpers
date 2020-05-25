using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UnityHelpers.CanvasHelpers
{
	/// <summary>Creates pagination on a set of canvas items. Examples of set of canvas items: images gallery, score ranking table.</summary>
    public class CanvasItemsPaginationManager : MonoBehaviour
    {
        #region Inspector Fields
        public Button previousButton, nextButton;
        public TextMeshProUGUI pagesLabel;
        #endregion

        private int numberOfItemsPerPage;
        private int currentPage = 1, numberOfPages;
        private List<GameObject> items;
        private List<Vector3> positions;
		
		/* The "List<Vector3> positions" parameter refers to all positions that the item can take on a page.
		   Example: in a score ranking table with 15 rows per page, the "List<Vector3> positions" parameter must be
		   a list with 15 elements (each Vector3 is a position). The CanvasItemsPaginationManager will distribute all
		   the items on pages with 15 elements. */
        public void StartPagination(List<GameObject> items, List<Vector3> positions, int numberOfItemsPerPage)
        {
            this.items = items;
            this.numberOfItemsPerPage = numberOfItemsPerPage;
            this.positions = positions;

            AddEventListenersToTheButtons();
            SetItemsPositions();
            CalculateNumberOfPages();
            EnableCurrentPageItems();
        }

        private void AddEventListenersToTheButtons()
        {
            previousButton.onClick.AddListener(ChangeToPreviousPage);
            nextButton.onClick.AddListener(ChangeToNextPage);
        }

        private void ChangeToPreviousPage()
        {
            currentPage--;
            EnableCurrentPageItems();
        }

        private void ChangeToNextPage()
        {
            currentPage++;
            EnableCurrentPageItems();
        }

        private void SetItemsPositions()
        {
            for (int i = 0; i < items.Count; i++)
            {
                int positionIndex = i - (numberOfItemsPerPage * (i / numberOfItemsPerPage));
                items[i].transform.localPosition = positions[positionIndex];
            }
        }

        private void CalculateNumberOfPages()
        {
            if (items.Count == numberOfItemsPerPage)
                numberOfPages = 1;
            else
                numberOfPages = (items.Count / numberOfItemsPerPage) + 1;
        }

        private void EnableCurrentPageItems()
        {
            for (int i = 0; i < items.Count; i++)
                items[i].SetActive(false);

            int limit = currentPage * numberOfItemsPerPage;
            int currentIndex = (currentPage - 1) * numberOfItemsPerPage;

            while (currentIndex < limit)
            {
                if (currentIndex >= items.Count)
                    break;

                items[currentIndex].SetActive(true);
                currentIndex++;
            }

            SetPagesLabelText();
            SetButtonsFunctionality();
        }

        private void SetPagesLabelText() => pagesLabel.text = $"{currentPage}/{numberOfPages}";

        private void SetButtonsFunctionality()
        {
            if (currentPage == 1)
                previousButton.interactable = false;
            else
                previousButton.interactable = true;

            if (currentPage == numberOfPages)
                nextButton.interactable = false;
            else
                nextButton.interactable = true;
        }
    }
}