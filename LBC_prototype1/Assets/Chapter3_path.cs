using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public GameObject book;
    
    public GameObject page1;
    public GameObject page2;

    public Animator loadscreen;
    public GameObject scene_;

    public int portal_count = 3;
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public GameObject block5;

    public GameObject Game_data;

    // Use this for initialization
    void Start () {

        Game_data = GameObject.Find("Game_data");
    }

    public void activatediag(bool dialogue)
    {
        slide.SetBool("start_slide", dialogue);
        lines.text = "Wait, is this outside my parent's house?";
        line_one = numboftime;
        line_part = "first line";
        StartCoroutine("LoseTime");
    }
    public void activatebook(bool objective)
    {
        slide.SetBool("start_slide", objective);
        lines.text = "This Book.. it's our photo album!..";
        line_one = numboftime;
        line_part = "second line";
        StartCoroutine("LoseTime");
    }
    public void activategoup(bool go)
    {
        slide.SetBool("start_slide", go);
        lines.text = "I might find something uphill";
        line_one = numboftime;
        line_part = "third line";
        StartCoroutine("LoseTime");
    }
    public void activateup(bool up)
    {
        slide.SetBool("start_slide", up);
        lines.text = "Wow! what a view we have here!!";
        line_one = numboftime;
        line_part = "fourth line";
        StartCoroutine("LoseTime");
    }
    public void activatepage1(bool page1)
    {
        slide.SetBool("start_slide", page1);
        lines.text = "Wait! is this.. me and my dads picture!?";
        line_one = numboftime;
        line_part = "fifth line";
        StartCoroutine("LoseTime");
    }


    public void activatediag2(bool dialogue)
    {
        slide.SetBool("start_slide", dialogue);
        lines.text = "This is crazy!";
        line_one = numboftime;
        line_part = "sixth line";
        StartCoroutine("LoseTime");
    }
    public void activategoup2(bool go)
    {
        slide.SetBool("start_slide", go);
        lines.text = "oh! a board full of posters..";
        line_one = numboftime;
        line_part = "seventh line";
        StartCoroutine("LoseTime");
    }
    public void activatepage2(bool page2)
    {
        slide.SetBool("start_slide", page2);
        lines.text = "Oh! I found it!";
        line_one = numboftime;
        line_part = "eight line";
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
                            lines.text = "I barely go outside when i was a kid.";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 3:
                            lines.text = "I think this is my third time going here near the camp.";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 4:
                            slide.SetBool("start_slide", false);
                            book.tag = "Mysterious Book";
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
                            lines.text = "(look whats inside the book)";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;

                        case 3:
                            lines.text = "There are some pictures missing here";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 4:
                            lines.text = "On the last page, it says, 'look around, find the truth.'";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 5:
                            lines.text = "I guess I should go and look around. I might find something useful";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 6:
                            slide.SetBool("start_slide", false);
                            book.tag = "static_obj";
                            block1.SetActive(false);
                            block2.SetActive(false);
                            block3.SetActive(false);
                            block4.SetActive(false);
                            block5.SetActive(false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            objpanel.SetBool("obj_slide", false);
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
                            lines.text = "Oh! I remember!";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            lines.text = "This is the place where my Dad brought me to see our house uphill when I was child!";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 4:
                            lines.text = "Dad..";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 5:
                            slide.SetBool("start_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            page1.tag = "Missing Picture";
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

                        case 2:
                            lines.text = "This picture was part of that book";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            lines.text = "!!!";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 4:
                            lines.text = "I feel strange.. somethings Happening..";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 5:
                            slide.SetBool("start_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
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


        if (obj_next == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Look around the forest";
            Inventory_story story = inventory.GetComponent<Inventory_story>();
            story.key_access = true;
        }

        if (obj_next2 == 0)
        {
            objpanel.SetBool("obj_slide", false);
            loadscreen.SetBool("load", true);
            loadscreen.SetBool("open", false);
            StartCoroutine("loads");
            DontDestroyOnLoad(Game_data);
            DontDestroyOnLoad(scene_);
            Inventory_story story = inventory.GetComponent<Inventory_story>();
            story.key_access = true;
        }

        if (line_part == "sixth line")
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
                            lines.text = "I'm glad I made it!";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            lines.text = "ugh! my head hurts!";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 4:
                            lines.text = "I'd better go now and find more clues..";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 5:
                            lines.text = "I need to end this.";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 6:
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
                            lines.text = "Let's see if we can find something here";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                       
                        case 4:
                            slide.SetBool("start_slide", false);
                            next_key.SetActive(false);
                            StopCoroutine("LoseTime");
                            page2.tag = "Missing Picture";
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
                            lines.text = "The last missing picture on our photo album..";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 3:
                            lines.text = "I miss them..";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 4:
                            lines.text = "I miss them so much..";

                            line_one = numboftime;
                            next_key.SetActive(false);
                            break;
                        case 5:
                            slide.SetBool("start_slide", false);
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

        if (obj_next3 == 0)
        {
            objpanel.SetBool("obj_slide", false);
            loadscreen.SetBool("load", true);
            loadscreen.SetBool("open", false);
            StartCoroutine("loads");
            DontDestroyOnLoad(Game_data);
            DontDestroyOnLoad(scene_);
            Inventory_story story = inventory.GetComponent<Inventory_story>();
            story.key_access = true;
        }

        if (portal_count == 0)
        {
            SceneManager.LoadScene("Storyline");
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

    IEnumerator loads()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            portal_count--;



        }
    }

}
