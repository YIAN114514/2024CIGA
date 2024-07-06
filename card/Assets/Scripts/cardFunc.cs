using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardFunc : MonoBehaviour
{
    public Card selectCard;

    [SerializeField] GameObject[] CheckPoint; 

    [SerializeField]  int[] selectNumber;//储存检测到的数字，从左往右，从上到下

    private void OnEnable()
    {
        selectCard = GetComponent<Card>();

        selectCard.CardDownEvent.AddListener(CardDown);

        selectNumber = new int[CheckPoint.Length];
    }

    private void CardDown(Card card)
    {
        GetNumber();

    }

    private void GetNumber()
    {
        //Debug.Log("卡牌放置");

        int i = 0;
        foreach (GameObject obj in CheckPoint)
        {
            RaycastHit2D hit = Physics2D.Raycast(obj.transform.position, Vector2.zero);
            //Debug.Log("点位检测");
            if (hit.collider != null)
            {

                //将射线检测到的number记录在int数组里
                selectNumber[i] = hit.collider.gameObject.GetComponent<Tilemapnumber>().realNumber;

                Debug.Log("Hit " + hit.collider.name + selectNumber[i]);
            }
            i++;
        }
    }
}
