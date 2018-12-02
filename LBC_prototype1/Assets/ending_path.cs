using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ending_path : MonoBehaviour {

   
    public Animator slide;
    public Animator objpanel;
    public Animator objtracker;
    public KeyCode next;

    public Text lines;

    private string line_part;
    private int line_one;
    private int obj_next = 1;

    public GameObject Door1;
    public GameObject Door2;
    //private int line_two;
    //private int line_three;
    private int marcus_lines = 1;
    public GameObject next_key;

    public int numboftime = 1;

    public Text obj_text;

    public string game_stage;
   
    public Animator loadscreen;
    public GameObject scene_;
   
    public int portal_count = 3;

    public GameObject Game_data;

    // Use this for initialization
    void Start () {
        Game_data = GameObject.Find("Game_data");
    }

    public void activatediag(bool dialogue)
    {
        slide.SetBool("start_slide", dialogue);
        lines.text = "Wait, is this for real now?";
        line_one = numboftime;
        line_part = "first line";
        StartCoroutine("LoseTime");
    }
    public void activateobj(bool objective)
    {
        slide.SetBool("start_slide", objective);
        lines.text = "Maybe I should check my parent's room one last time before I leave";
        line_one = numboftime;
        line_part = "second line";
        StartCoroutine("LoseTime");
    }
    // Update is called once per frame
    void Update ()
    {
		if (line_part == "first line")
        {
            if (line_one == -1)
            {
                next_key.SetActive(true);
            }

            if (next_key.activeSelf)
            {
                if (Input.GetKeyDown(next))
                {
                    marcus_lines += 1;

                    switch (marcus_lines)
                    {
                        case 2:
                            lines.text = "I guess I should go home";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            lines.text = "But that mysterious guy said that I should be brave and face the consequences";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 4:
                            lines.text = ".. Now I feel scared that something bad might happen";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 5:
                            slide.SetBool("start_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            Door1.tag = "Door";
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "second line")
        {
            if (line_one == -1)
            {
                next_key.SetActive(true);
            }

            if (next_key.activeSelf)
            {
                if (Input.GetKeyDown(next))
                {
                    marcus_lines += 1;

                    switch (marcus_lines)
                    {

                        case 2:
                            Door2.tag = "Door";
                            slide.SetBool("start_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            objpanel.SetBool("obj_slide", true);
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            line_one--;



        }
    }
}
