using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour
{
    [SerializeField] int rows;//行数
    [SerializeField] int columns;//列数

    [SerializeField] int tileSize;

    [SerializeField] GameObject mapTile;


    private void OnEnable()
    {
        tileSize = (int)mapTile.GetComponent<RectTransform>().sizeDelta.x;
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateMap()
    {
        for (int col = 0; col < columns; col++)
        {
            for (int row = 0; row < rows; row++)
            {

                // 计算Tile的位置
                float xPosition = col * tileSize - rows * tileSize / 2;
                float yPosition = row * tileSize - columns * tileSize / 2;

                // 创建Tile
                GameObject newTile = Instantiate(mapTile, transform);


                //设置tile的ID
                newTile.GetComponent<Tilemapnumber>().SetMapID(col,row);


                // 设置Tile的位置
                RectTransform rectTransform = newTile.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2(xPosition, -yPosition);
                // 将Tile作为地图生成器的子对象
                newTile.transform.SetParent(this.transform);

                //rectTransform.sizeDelta = new Vector2(tileSize, tileSize);
            }
        }
    }

}
