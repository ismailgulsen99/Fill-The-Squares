using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid_Animation : MonoBehaviour
{
    public static int gridsize;
    public GameObject grid;
    public bool is_Game_Over;
    private float grid_Speed = 0.1f;
    void Start()
    {
        is_Game_Over = false;

    }

    
    void Update()
    {
        if(gridsize == 3 && grid.tag == "3x3 Board")
        {
            if(grid.transform.position.y >= 1344.0f)
            {
                grid.transform.position = new Vector3(621.0f, 1344.0f, 0.0f);
            }

            else
            {
                grid.transform.Translate(Vector3.up * grid_Speed);
            }
        }

        else if(gridsize == 4 && grid.tag == "4x4 Board")
        {
            if(grid.transform.position.y >= 1346.5f)
            {
                grid.transform.position = new Vector3(621.0f, 1346.5f, 0.0f);
            }

            else
            {
                grid.transform.Translate(Vector3.up * grid_Speed);
            }
        }

        else if(gridsize == 5 && grid.tag == "5x5 Board")
        {
            if(grid.transform.position.y >= 1347.0f)
            {
                grid.transform.position = new Vector3(621.0f, 1347.0f, 0.0f);
            }

            else
            {
                grid.transform.Translate(Vector3.up * grid_Speed);
            }
        }


        if (is_Game_Over == false)   //eğer oyun devam ediyorsa, süre bitmemişse eklenecek
        {
            
        }

        //if(zaman biterse || kareler dolarsa) is_Game_Over = true;
    }
}
