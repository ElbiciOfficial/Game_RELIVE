using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_game_story : MonoBehaviour {

    public GameObject gamemanager;
    public GameObject pause_menu;
    public Button startbutton;
    public Animator pause_pad;

    void Start()
    {
        Button strt = startbutton.GetComponent<Button>();
        strt.onClick.AddListener(ToggleStart);
    }
    public void ToggleStart()
    {
        game_starte_story start = gamemanager.GetComponent<game_starte_story>();
        pause_pad.SetBool("pause", true);
        PauseMenu pm = pause_menu.GetComponent<PauseMenu>();
        pm.menu_panel = true;

        start.startpanel.SetActive(false);
        start.startgame(true);
    }
}
