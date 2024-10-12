using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonAnimScript : MonoBehaviour
{
    public RectTransform image;
    public Image uiImage;
    private Vector3 originalPos;
    private bool slideUpActive, slideDownActive;

    void Start()
    {
        originalPos = image.localPosition;
    }

    public void SlideUp()
    {
        if (slideUpActive)
            image.DOLocalMoveY(originalPos.y, 0.5f).SetEase(Ease.OutQuad);
        else
            image.DOLocalMoveY(originalPos.y - 200, 0.5f).SetEase(Ease.InQuad);
        slideUpActive = !slideUpActive;
    }

    public void SlideDown()
    {
        if (slideDownActive)
            image.DOLocalMoveY(originalPos.y, 0.5f).SetEase(Ease.OutQuad);
        else
            image.DOLocalMoveY(originalPos.y + 200, 0.5f).SetEase(Ease.InQuad);
        slideDownActive = !slideDownActive;
    }

    public void Jiggle()
    {
        image.DOShakePosition(0.5f, 10, 10).SetEase(Ease.Linear);
    }

    public void Shake()
    {
        image.DOShakePosition(0.5f, new Vector3(20, 0, 0), 10, 90, false, true).SetEase(Ease.Linear);
    }

    public void Pulse()
    {
        uiImage.DOFade(0.5f, 0.2f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    public void Zoom()
    {
        image.DOScale(new Vector3(5f, 5f, 1), 0.5f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.InOutBack);
    }
}
