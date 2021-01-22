using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject wall;

    void Start()
    {
        PaintStartWall();
    }

    void Update()
    {
        
    }

    void PaintStartWall()
    {
        for (int i = 1; i <= 100; i++)
        {
            Instantiate(wall, new Vector3(i, 1, 0), Quaternion.identity);
            Instantiate(wall, new Vector3(i, 50, 0), Quaternion.identity);
        }

        for (int j = 1; j <= 50; j++)
        {
            Instantiate(wall, new Vector3(1, j, 0), Quaternion.identity);
            Instantiate(wall, new Vector3(100, j, 0), Quaternion.identity);
        }
    }
}
