using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public bool[,] marks;
    public int sizeX = 3;
    public int sizeY = 3;
    public int[] mines = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log(mines[0]);
        Debug.Log(marks[0]);*/

        mines = new int[12];

        for (int i = 0; i < mines.Length; i++)
        {
            mines[i] = Random.Range(0, 8);
        }

        /*
            xxxxxxxxxxxxxxx  x->>>
            x
            x
            x
        y
         */

        marks = new bool [sizeX, sizeY];

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                if(Random.value <0.5f)
                {
                    marks[x, y] = true;
                }else
                {
                    marks[x, y] = false;
                }

            }
        }
    }
 
}
