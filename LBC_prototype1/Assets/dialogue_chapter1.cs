using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue_chapter1 : MonoBehaviour {

    public Animator slide;
    private int line_one;
    public int numboftime = 1;
    private string line_part;
    public GameObject next_key;
    private int marcus_lines = 1;

    public KeyCode next;

    public Text lines;

    public GameObject gamemanager;

    private string scene_diag;

    // Use this for initialization
    void Start () {
        game_starter Game = gamemanager.GetComponent<game_starter>();
        scene_diag = Game.stage_type;
    }
	

    public void story_part(bool start)
    {
        if (scene_diag == "chapter1_stage1")
        {
            slide.SetBool("start_slide", start);
            lines.text = "Wha-?!  What is this place?";
            line_one = numboftime;
            line_part = "first line";
            StartCoroutine("LoseTime");
        }else if (scene_diag == "chapter1_stage3")
        {
            slide.SetBool("start_slide", start);
            lines.text = "Now what!? those tall upright strucutres became a giant spheres!!";
            line_one = numboftime;
            line_part = "second line";
            StartCoroutine("LoseTime");
        }
        else if (scene_diag == "chapter2_stage1")
        {
            slide.SetBool("start_slide", start);
            lines.text = "Ok let's see what's new here!";
            line_one = numboftime;
            line_part = "third line";
            StartCoroutine("LoseTime");
        }
        else if (scene_diag == "chapter2_stage3")
        {
            slide.SetBool("start_slide", start);
            lines.text = "Ugh!! I'm tired of this..";
            line_one = numboftime;
            line_part = "third line";
            StartCoroutine("LoseTime");
        }
        else if (scene_diag == "chapter3_stage1")
        {
            slide.SetBool("start_slide", start);
            lines.text = "Wow the place keeps changing everytime I go here!";
            line_one = numboftime;
            line_part = "third line";
            StartCoroutine("LoseTime");
        }
        else if (scene_diag == "chapter3_stage3")
        {
            slide.SetBool("start_slide", start);
            lines.text = "For the Last time I can do this!!";
            line_one = numboftime;
            line_part = "third line";
            StartCoroutine("LoseTime");
        }
    }
       
	// Update is called once per frame
	void Update () {

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
                            lines.text = "Where am I?";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;                   
                        case 3:
                            slide.SetBool("start_slide", false);
                            game_starter Game = gamemanager.GetComponent<game_starter>();
                            Game.count_down(true);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
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
                            lines.text = "Now I know how this works!";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            game_starter Game = gamemanager.GetComponent<game_starter>();
                            Game.count_down(true);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            line_one = numboftime;
                            marcus_lines = 1;

                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "third line")
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
                            slide.SetBool("start_slide", false);
                            game_starter Game = gamemanager.GetComponent<game_starter>();
                            Game.count_down(true);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
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
