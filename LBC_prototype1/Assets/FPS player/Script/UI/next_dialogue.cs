using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class next_dialogue : MonoBehaviour {

    public GameObject panel;
    public Button nextbutton;
    public GameObject door1_1;
    public GameObject door1_2;

    void Start()
    {
        Button strt = nextbutton.GetComponent<Button>();
        strt.onClick.AddListener(ToggleStart);
    }
    public void ToggleStart()
    {
        //game_starte_story start = gamemanager.GetComponent<game_starte_story>();
        door1_1.tag = "Door";
        door1_2.tag = "Door";

    }
}
