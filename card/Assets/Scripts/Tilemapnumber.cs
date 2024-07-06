using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tilemapnumber : MonoBehaviour
{
    public int[,] mapID;

    public int iDx;
    public int iDy;

    public TextMeshProUGUI numberTXT;

    public int realNumber;

    [SerializeField] float changeTime = 0.08f;
    WaitForSeconds waitForChangeTime;

    private void OnEnable()
    {
        realNumber = Random.Range(0, 9);//暂时随机

        waitForChangeTime = new WaitForSeconds(changeTime);

        StartCoroutine(ChangeNumberCoroutine(realNumber));
    }

    public void SetMapID(int x ,int y)
    {
        iDx = x;
        iDy = y;

        mapID = new int[x, y];
    }


    public void ChangeToNewNumber(int num)
    {
        realNumber = num;

        StartCoroutine(ChangeNumberCoroutine(realNumber));
    }

    IEnumerator ChangeNumberCoroutine(int num)
    {
        int fluctuate = Random.Range(6, 10);

        for(int i = 0;i< fluctuate; i++)
        {
            numberTXT.text = Random.Range(0, 10).ToString();
            yield return waitForChangeTime ;
        }

        numberTXT.text = num.ToString();



    }

}
