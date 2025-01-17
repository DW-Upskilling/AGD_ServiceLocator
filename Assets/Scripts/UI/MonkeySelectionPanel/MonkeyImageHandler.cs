using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ServiceLocator.UI
{
    public class MonkeyImageHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerDownHandler
    {
        private Image monkeyImage;
        private MonkeyCellController owner;
        private Sprite spriteToSet;
        private RectTransform rectTransform;
        private Vector3 originalPosition;
        private Vector3 originalAnchoredPosition;
        private LayoutElement layoutElement;

        public void ConfigureImageHandler(Sprite spriteToSet, MonkeyCellController owner)
        {
            this.spriteToSet = spriteToSet;
            this.owner = owner;
        }

        private void Awake()
        {
            monkeyImage = GetComponent<Image>();
            monkeyImage.sprite = spriteToSet;

            rectTransform = GetComponent<RectTransform>();
            layoutElement = GetComponent<LayoutElement>();

            originalPosition = rectTransform.position;
            originalAnchoredPosition = rectTransform.anchoredPosition;
        }

        public void OnDrag(PointerEventData eventData)
        {
            rectTransform.anchoredPosition += eventData.delta;

            owner.MonkeyDraggedAt(eventData.position);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            ResetMonkey();

            owner.MonkeyDroppedAt(eventData.position);
        }

        private void ResetMonkey() {
            layoutElement.enabled = false;
            rectTransform.position = originalPosition;
            rectTransform.anchoredPosition = originalAnchoredPosition;
            layoutElement.enabled = true;
            monkeyImage.color = new Color(1, 1, 1, 1f);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            monkeyImage.color = new Color(1, 1, 1, .6f);
        }
    }
}