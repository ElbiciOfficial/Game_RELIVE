using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_game_story : MonoBehaviour {

    public GameObject gamemanager;
    public Button startbutton;
   

    void Start()
    {
        Button strt = startbutton.GetComponent<Button>();
        strt.onClick.AddListener(ToggleStart);
    }
    public void ToggleStart()
    {
        game_starte_story start = gamemanager.GetComponent<game_starte_story>();

        start.startpanel.SetActive(false);
        start.startgame(true);
    }
}
