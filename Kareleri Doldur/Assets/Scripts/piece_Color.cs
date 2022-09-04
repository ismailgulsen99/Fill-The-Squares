using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece_Color : MonoBehaviour
{
    string[] pieceColor = new string[10] { "#CC0000", "#0099FF", "#00CC00", "#660099", "#CC33CC", "#33CCCC", "#FFCC00", "#FF6600", "#0000CC", "#FF6666" };
    public static int[] pieces = new int[9];
    public static int[] angles = new int[9];

    [SerializeField] GameObject which_Piece;

    Color newColor;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
