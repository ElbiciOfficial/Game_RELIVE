using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chapter2_path : MonoBehaviour {

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

    private int marcus_lines = 1;
    public GameObject next_key;

    public GameObject stand;
    public GameObject sketch;
    public int numboftime = 1;

    public Text obj_text;
    public Text item_text;

    public GameObject door1;
    public GameObject rob1;
    public GameObject rob2;
    public GameObject robot1;
    public GameObject robot2;
    public GameObject portal;
    public string game_stage;

    public GameObject wall;

    void Start()
    {
        start = gamemanager.GetComponent<game_starte_story>();
        game_stage = start.stage;    
        door1.tag = "static_obj";
        stand.tag = "static_obj";
        sketch.tag = "static_obj";
        cam = playercam.GetComponent<headbob>();

    }

    public void activatediag(bool dialogue)
    {
        slide.SetBool("start_slide", dialogue);

        line_one = numboftime;
        line_part = "first line";
        StartCoroutine("LoseTime");
    }
    public void activatediag2(bool dialogue2)
    {
        slide.SetBool("start_slide", dialogue2);
        lines.text = "this place";
        line_one = numboftime;
        line_part = "second line";
        StartCoroutine("LoseTime");
    }
    public void activatediag3(bool dialogue3)
    {
        slide.SetBool("start_slide", dialogue3);
        lines.text = "whats with this one";
        line_one = numboftime;
        line_part = "third line";
        StartCoroutine("LoseTime");
    }
    public void activatesketch(bool sketch)
    {
        slide.SetBool("start_slide", sketch);
        lines.text = "whats with this drawing";
        line_one = numboftime;
        line_part = "fourth line";
        StartCoroutine("LoseTime");
    }
    public void activaterob(bool robot)
    {
        slide.SetBool("start_slide", robot);
        lines.text = "may be i need to find that toy somewhere here";
        line_one = numboftime;
        line_part = "fifth line";
        StartCoroutine("LoseTime");
    }
    public void robpiece1(bool robot)
    {
        slide.SetBool("start_slide", robot);
        lines.text = "i found it!";
        line_one = numboftime;
        line_part = "sixth line";
        StartCoroutine("LoseTime");
    }
    public void piece1done(bool robot)
    {
        stand.tag = "static_obj";
        slide.SetBool("start_slide", robot);
        lines.text = "I still need to find the other part";
        line_one = numboftime;
        line_part = "seventh line";
        rob1.SetActive(true);
        StartCoroutine("LoseTime");
    }


    public void activatediag4(bool dialogue4)
    {
        slide.SetBool("start_slide", dialogue4);
        lines.text = "ok now I'm here again";
        line_one = numboftime;
        line_part = "eight line";
        StartCoroutine("LoseTime");
    }
    public void robpiece2(bool robot2)
    {
        slide.SetBool("start_slide", robot2);
        lines.text = "i found it!";
        line_one = numboftime;
        line_part = "ninth line";
        StartCoroutine("LoseTime");
    }
    public void piece2done(bool robot2)
    {
        stand.tag = "static_obj";
        slide.SetBool("start_slide", robot2);
        lines.text = "at last I've done it";
        line_one = numboftime;
        line_part = "tenth line";
        rob2.SetActive(true);
        StartCoroutine("LoseTime");
    }


    // Update is called once per frame
    void Update()
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
                            lines.text = "gg";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 3:
                            lines.text = "Reddsa..";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 4:
                            slide.SetBool("start_slide", false);                          
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            line_one = numboftime;
                            marcus_lines = 1;
                            Destroy(wall);
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
                            lines.text = "s";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 3:
                            slide.SetBool("start_slide", false);
                            //stand.tag = "Empty Stand";
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
                            lines.text = "it looks like a drawing of someone";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 3:
                            slide.SetBool("start_slide", false);
                            sketch.tag = "Sketch";
                            objpanel.SetBool("obj_slide", true);
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
        else if (line_part == "fourth line")
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
                            lines.text = "same as the toy that I want when I was a kid";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            objpanel.SetBool("obj_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            stand.tag = "Empty Stand";
                            StartCoroutine("nextobj");
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "fifth line")
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
                        //case 2:
                        //    lines.text = "same as the toy that I want when I was a kid";

                        //    line_one = numboftime;
                        //    next_key.SetActive(false);
                        //    break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            objpanel.SetBool("obj_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            stand.tag = "static_obj";
                            StartCoroutine("nextobj2");
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "sixth line")
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
                        //case 2:
                        //    lines.text = "same as the toy that I want when I was a kid";

                        //    line_one = numboftime;
                        //    next_key.SetActive(false);
                        //    break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            objpanel.SetBool("obj_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            
                            StartCoroutine("nextobj3");
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "seventh line")
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
                            lines.text = "another portal!";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            objpanel.SetBool("obj_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");

                            StartCoroutine("nextobj4");
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "eight line")
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
                            lines.text = "I'll go find the other part of that robot";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            objpanel.SetBool("obj_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");

                            StartCoroutine("nextobj5");
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "ninth line")
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
                            lines.text = "sssssss";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            objpanel.SetBool("obj_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");

                            StartCoroutine("nextobj6");
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }
        else if (line_part == "tenth line")
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
                            lines.text = "now whats next";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            slide.SetBool("start_slide", false);
                            objpanel.SetBool("obj_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");

                            StartCoroutine("nextobj7");
                            line_one = numboftime;
                            marcus_lines = 1;
                            break;

                        default:

                            break;

                    }
                }
            }


        }

        if (obj_next == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Check the Stand";        
            sketch.tag = "static_obj";
        }
        if (obj_next2 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Find the first piece";
            objtracker.SetBool("start_obj", true);
            robot1.SetActive(true);
        }
        if (obj_next3 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Place it back to the stand";
      
            objtracker.SetBool("obj_complete", true);
            item_text.text = "1/1 - Robot Piece";
            stand.tag = "Empty Stand";
        }
        if (obj_next4 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Enter the portal";         
            objtracker.SetBool("close_obj", true);
            portal.SetActive(true);
        }
        if (obj_next5 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Find the other part";
            objtracker.SetBool("start_obj", true);
            robot2.SetActive(true);
        }
        if (obj_next6 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Place it back to complete the parts";
            objtracker.SetBool("obj_complete", true);
            item_text.text = "1/1 - Robot Piece";
            stand.tag = "Empty Stand";
        }
        if (obj_next7 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Enter the portal";
            objtracker.SetBool("close_obj", true);
            portal.SetActive(true);
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

    IEnumerator nextobj()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            obj_next--;



        }
    }
    IEnumerator nextobj2()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            obj_next2--;



        }
    }
    IEnumerator nextobj3()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            obj_next3--;



        }
    }
    IEnumerator nextobj4()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            obj_next4--;



        }
    }
    IEnumerator nextobj5()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            obj_next5--;



        }
    }
    IEnumerator nextobj6()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            obj_next6--;



        }
    }
    IEnumerator nextobj7()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            obj_next7--;



        }
    }


}
