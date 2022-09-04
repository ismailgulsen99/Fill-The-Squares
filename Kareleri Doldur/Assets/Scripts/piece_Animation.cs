using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class piece_Animation : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    Vector3 position;
    Vector3 piece_Position;
    private float rotate = 0f;
    [SerializeField] GameObject which_Piece;
    public static int[] pieces = new int[9];
    public static int[] angles = new int[9];
    private float piece_Speed = 0.05f;

    void Start()
    {
        position = new Vector3(Random.Range(620.0f, 622.0f), Random.Range(1339.5f, 1341.0f), 0.0f);


    }

    #region Rotating

    public void OnPointerClick(PointerEventData event_Data)
    {
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics2D.Raycast(ray.origin, ray.direction))
        {
            rotate -= 90.0f;
            LeanTween.rotate(which_Piece, new Vector3(0f, 0f, rotate), 0f);
        }*/
    }
    #endregion

    #region Scaling
    public void OnPointerDown(PointerEventData event_Data)
    {
        if (which_Piece.tag.Contains("Piece"))
        {
            if (which_Piece.tag == "Piece 1")
            {
                piece_Position = which_Piece.transform.position;
                LeanTween.scale(which_Piece, new Vector3(0.9f, 0.9f, 0.9f), 0f);
            }

            else
            {
                LeanTween.scale(which_Piece, new Vector3(3.6f, 3.6f, 3.6f), 0f);
            }
        }
    }

    public void OnPointerUp(PointerEventData event_Data)
    {
        if (which_Piece.tag.Contains("Piece"))
        {
            if (which_Piece.tag == "Piece 1")
            {
                LeanTween.scale(which_Piece, new Vector3(0.25f, 0.25f, 0.25f), 0f);
            }

            else
            {
                LeanTween.scale(which_Piece, new Vector3(1.0f, 1.0f, 1.0f), 0f);
            }
        }
    }
    #endregion
    void Update()
    {
        #region Pieces
        for (int i = 0; i < pieces.Length; i++)
        {

            switch (pieces[i])
            {
                case 1:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 1")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 2:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 2")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 3:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 3")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 4:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 4")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 5:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 5")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 6:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 6")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 7:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 7")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 8:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 8")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 9:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 9")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 10:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 10")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 11:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 11")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
                case 12:
                    if (which_Piece.transform.position.y >= position.y && which_Piece.tag == "Piece 12")
                    {
                        which_Piece.transform.position = position;
                    }

                    else
                    {
                        which_Piece.transform.Translate(Vector3.up * piece_Speed);
                    }
                    break;
            }

        }
        #endregion

        
    }
}
