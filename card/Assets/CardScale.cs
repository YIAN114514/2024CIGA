using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScale : MonoBehaviour
{
    public RectTransform cardRoot;

    public RectTransform cardPic;
    public Sprite sprite; // 要加载的图片的Sprite

    void Start()
    {
        cardRoot = GetComponent<RectTransform>();

        if (cardRoot != null && sprite != null)
        {


            // 获取图片的宽度和高度
            float imageWidth = sprite.rect.width;
            float imageHeight = sprite.rect.height;

            cardPic.sizeDelta = new Vector2(imageWidth, imageHeight);

            //cardRoot.sizeDelta.x

            // 设置RectTransform的大小
            cardRoot.sizeDelta = new Vector2(imageWidth, imageHeight);
        }
    }
}
