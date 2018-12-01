using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Chapter3_path : MonoBehaviour {

    public GameObject gamemanager;
    public Camera playercam;
    public Animator slide;
    public Animator objpanel;
    public Animator objtracker;

    private game_starte_story start;
    private headbob cam;


    public KeyCode next;

    public Text lines;

    private string line_part;
    private int line_one;
    private int obj_next = 1;
    private int obj_next2 = 1;
    private int obj_next3 = 1;
    private int obj_next4 = 1;
    private int obj_next5 = 1;
    private int obj_next6 = 1;
    private int obj_next7 = 1;
    //private int line_two;
    //private int line_three;
    private int marcus_lines = 1;
    public GameObject next_key;

    public int numboftime = 1;

    public Text obj_text;
    public GameObject inventory;
    public GameObject inventoryicon;

    public Text item_text;

    public string game_stage;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
