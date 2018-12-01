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


    // Use this for initialization
    void Start () {
		
	}
	

    public void story_part(bool start)
    {
        slide.SetBool("start_slide", start);

        line_one = numboftime;
        line_part = "first line";
        StartCoroutine("LoseTime");
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
                            lines.text = "WHERE AM I!!??";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 3:
                            lines.text = "AM I DREAMING?";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 4:
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
