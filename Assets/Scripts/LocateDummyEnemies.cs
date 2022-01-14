using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocateDummyEnemies : MonoBehaviour
{
    public Vector2 pivotPoint;
    public int columnCount;
    public int rowCount;
    public float stepSize;
    public Enemy dummyEnemy;


    void Awake()
    {
        int colStart = (int)(pivotPoint.x - (columnCount * stepSize));
        int rowStart = (int)(pivotPoint.y - (rowCount * stepSize));

        int colEnd = (int)(pivotPoint.x + (columnCount * stepSize));
        int rowEnd = (int)(pivotPoint.y + (rowCount * stepSize));


        for (int i = colStart; i <= colEnd; i++)
        {
            for (int j = rowStart; j < rowEnd; j++)
            {
                Instantiate(dummyEnemy, new Vector3(i * stepSize, j * stepSize, 0.0f), new Quaternion());
            }
        }
    }

}
