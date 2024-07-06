using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScale : MonoBehaviour
{


    public Sprite sprite; // 要加载的图片的Sprite

    RectTransform cardRoot;

    //卡牌视觉
    RectTransform cardVisualPic;
    Image cardImage;

    void Start()
    {
        cardRoot = GetComponent<RectTransform>();

        cardVisualPic = GetComponent<Card>().cardVisual.GetComponent<RectTransform>();


        // 获取图片的宽度和高度
        float imageWidth = sprite.rect.width;
        float imageHeight = sprite.rect.height;


        cardRoot.sizeDelta = new Vector2(imageWidth, imageHeight);

        cardVisualPic.sizeDelta = new Vector2(imageWidth, imageHeight);


        cardImage = cardVisualPic.gameObject.GetComponentInChildren<Image>();

        //Debug.Log(cardImage.name);
        cardImage.sprite = sprite;
        cardImage.rectTransform.sizeDelta = new Vector2(imageWidth, imageHeight);
        //    cardPic.sizeDelta = new Vector2(imageWidth, imageHeight);

        //    cardTouch .sizeDelta = new Vector2(imageWidth, imageHeight);

        //    //cardRoot.sizeDelta.x

        //    // 设置RectTransform的大小
        //    cardRoot.sizeDelta = new Vector2(imageWidth, imageHeight);
        //}
    }
}
