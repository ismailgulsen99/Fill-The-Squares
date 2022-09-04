using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scene_Controller : MonoBehaviour
{
    public Button button;
    [SerializeField]
    private Canvas main_Menu;
    [SerializeField]
    private Canvas level_1;
    [SerializeField]
    private Canvas which_Level;
    public static int choose_Level = 0;
    [SerializeField] TMP_InputField enter_Level;
    //game_Manager game_manager;
    void Awake()
    {
        level_1.gameObject.SetActive(false);
        which_Level.gameObject.SetActive(false);
    }

    public void on_Button_Click_For_Start()
    {
        game_Manager.starting();

        main_Menu.gameObject.SetActive(false);
        level_1.gameObject.SetActive(true);
    }

    public void on_Button_Click_For_Quit()
    {
        Application.Quit();
    }

    public void on_Button_Click_For_Level_Choose()
    {
        main_Menu.gameObject.SetActive(false);
        which_Level.gameObject.SetActive(true);

        if(enter_Level.text != "")
        {
            choose_Level = int.Parse(enter_Level.text);
            game_Manager.level = choose_Level - 1;

            Debug.Log(game_Manager.level);

            game_Manager.starting();

            which_Level.gameObject.SetActive(false);
            level_1.gameObject.SetActive(true);
        }
    }

    public void on_Button_Click_For_Return()
    {
        which_Level.gameObject.SetActive(false);
        main_Menu.gameObject.SetActive(true);
    }

}
