using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardFunc01 : MonoBehaviour
{
    public Card selectCard;

    private void OnEnable()
    {
        selectCard = GetComponent<Card>();

        selectCard.CardDownEvent.AddListener(CardDown);
    }

    private void CardDown(Card card)
    {
        //Debug.Log("卡牌放置");
        
    }

    private void GetNumber()
    {

    }
}
