using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_game : MonoBehaviour {

    public GameObject gamemanager;
    public GameObject pause_menu;
    public Button startbutton;
    public GameObject startpanel;
    public Animator pause_pad;


    void Start()
    {
        Button strt = startbutton.GetComponent<Button>();
            strt.onClick.AddListener(ToggleStart);
    }
    public void ToggleStart()
    {
     
        game_starter start = gamemanager.GetComponent<game_starter>();
        pause_pad.SetBool("pause", true);
        PauseMenu pm = pause_menu.GetComponent<PauseMenu>();
        pm.menu_panel = true;

        startpanel.SetActive(false);
        start.startgame(true);
    }
}
