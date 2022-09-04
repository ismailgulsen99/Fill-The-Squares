using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Newtonsoft.Json;
using System.Linq;

public class game_Manager : MonoBehaviour
{
    public static int level = 0;
    public TextMeshPro timer;
    public static void starting()
    {

        Level_Data p = new Level_Data();

        using (StreamReader r = new StreamReader("Assets/Scripts/Game159Params.json"))
        {
            string json_S = r.ReadToEnd();
            p = JsonConvert.DeserializeObject<Level_Data>(json_S);
        }


        //level = scene_Controller.choose_Level;

        float v = Convert.ToSingle(p.time[level]);
        assign_Time.level_Time = v;
        Debug.Log(assign_Time.level_Time);

        grid_Animation.gridsize = p.gridSize[level];
        Debug.Log(grid_Animation.gridsize);

        for (int j = 0; j < p.pieceIDs[level].Count; j++)
        {
            piece_Color.pieces[j] = p.pieceIDs[level][j];
            piece_Animation.pieces[j] = p.pieceIDs[level][j];
        }

        Debug.Log(piece_Color.pieces[0]);

        for (int j = 0; j < p.pieceAngles[level].Count; j++)
        {
            piece_Color.angles[j] = p.pieceAngles[level][j];
            piece_Animation.angles[j] = p.pieceAngles[level][j];
        }

    }

    void Update()
    {
        level = scene_Controller.choose_Level;
    }

    public class Level_Data
    {
        public List<int> gridSize { get; set; }
        public List<int> time { get; set; }
        public List<List<int>> pieceIDs { get; set; }
        public List<List<int>> pieceAngles { get; set; }
    }

}
