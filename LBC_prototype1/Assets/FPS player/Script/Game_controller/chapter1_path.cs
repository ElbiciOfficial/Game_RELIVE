using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chapter1_path : MonoBehaviour {

    public GameObject gamemanager;
    public Camera playercam;
    public Animator slide;
    public Animator objpanel;
    public Animator objtracker;
    
    private game_starte_story start;
    private headbob cam;
    public GameObject door1_1;
    public GameObject door1_2;
    public GameObject door2;
    public GameObject door3;

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

    public GameObject Urn;
    public int numboftime = 1;

    public Text obj_text;
    public GameObject inventory;
    public GameObject inventoryicon;
    public GameObject pic;
    public Text item_text;

    public GameObject pic1;
    public GameObject pic2;
    public GameObject picture1;
    public GameObject picture2;
    public GameObject portal;
    public string game_stage;

    void Start()
    {
        start = gamemanager.GetComponent<game_starte_story>();
        game_stage = start.stage;
        door1_1.tag = "static_obj";
        door1_2.tag = "static_obj";
        door2.tag = "static_obj";
        door3.tag = "static_obj";
        picture1.tag = "static_obj";
        picture2.tag = "static_obj";
        cam = playercam.GetComponent<headbob>();
      
    }

    public void activatediag(bool dialogue)
    {
        slide.SetBool("start_slide", dialogue);
       
        line_one = numboftime;
        line_part = "first line";
        StartCoroutine("LoseTime");
    }
    public void activateobj(bool objective)
    {
        slide.SetBool("start_slide", objective);
        lines.text = "Line 2";
        line_one = numboftime;
        line_part = "second line";
        StartCoroutine("LoseTime");
    }
    public void activateurn(bool urn)
    {
        Urn.tag = "static_obj";
        slide.SetBool("start_slide", urn);
        lines.text = "Urn's Empty PUTANG INA";
        line_one = numboftime;
        line_part = "third line";
        StartCoroutine("LoseTime");
    }
    public void activatepic(bool picture)
    {
        pic.tag = "static_obj";
        slide.SetBool("start_slide", picture);
        lines.text = "Where's our family picture heheheh";
        line_one = numboftime;
        line_part = "fourth line";
        StartCoroutine("LoseTime");
    }

    public void picpiece1(bool picture)
    {

        slide.SetBool("start_slide", picture);
        lines.text = "I found a piece!";
        line_one = numboftime;
        line_part = "fifth line";
        StartCoroutine("LoseTime");
    }

    public void piece1done(bool done)
    {
        pic.tag = "static_obj";
        slide.SetBool("start_slide", done);
        lines.text = "still not complete";
        line_one = numboftime;
        line_part = "sixth line";
        StartCoroutine("LoseTime");
        pic1.SetActive(true);

    }


    public void activateobj2(bool objective2)
    {
        slide.SetBool("start_slide", objective2);
        door1_1.tag = "static_obj";
        door1_2.tag = "static_obj";
        lines.text = "lines for stage 2";
        line_one = numboftime;
        line_part = "seventh line";
        StartCoroutine("LoseTime");
    }
    public void activatediag2(bool dialogue2)
    {
        slide.SetBool("start_slide", dialogue2);   
        lines.text = "why this room is empty?";
        line_one = numboftime;
        line_part = "eight line";
        StartCoroutine("LoseTime");
    }
    public void activatediag3(bool dialogue3)
    {
        slide.SetBool("start_slide", dialogue3);
        lines.text = "my room still looks the same";
        line_one = numboftime;
        line_part = "ninth line";
        StartCoroutine("LoseTime");
    }
    public void picpiece2(bool picture2)
    {

        slide.SetBool("start_slide", picture2);
        lines.text = "I found the other piece";
        line_one = numboftime;
        line_part = "tenth line";
        StartCoroutine("LoseTime");
    }
    public void piece2done(bool done)
    {
        pic.tag = "static_obj";
        slide.SetBool("start_slide", done);
        lines.text = "Its done";
        line_one = numboftime;
        line_part = "eleventh line";
        StartCoroutine("LoseTime");
        pic2.SetActive(true);

    }

    // Update is called once per frame
    void Update() {
       
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
                                lines.text = "This place is still beautiful and peaceful...";

                                line_one = numboftime;
                                next_key.SetActive(false);
                                break;

                            case 3:
                                lines.text = "Reminds me of my childhood...";

                                line_one = numboftime;
                                next_key.SetActive(false);
                                break;

                            case 4:
                                slide.SetBool("start_slide", false);
                                door1_1.tag = "Door";
                                door1_2.tag = "Door";
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
                                lines.text = "Line 2.1";
                            
                                line_one = numboftime;
                                next_key.SetActive(false);
                                break;
                            case 3:
                                next_key.SetActive(false);
                                slide.SetBool("start_slide", false);
                                StopCoroutine("LoseTime");
                                objpanel.SetBool("obj_slide", true);
                                Urn.tag = "Urn";
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
                                lines.text = "wala na kong madagdag";
                          
                                line_one = numboftime;
                                next_key.SetActive(false);
                                break;
                            case 3:
                                next_key.SetActive(false);
                                slide.SetBool("start_slide", false);
                                StopCoroutine("LoseTime");
                                objpanel.SetBool("obj_slide", false);
                                line_one = numboftime;
                                marcus_lines = 1;
                                StartCoroutine("nextobj");
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
                                lines.text = "I need to find it";

                                line_one = numboftime;
                                next_key.SetActive(false);
                                break;
                            case 3:
                                next_key.SetActive(false);
                                slide.SetBool("start_slide", false);
                                StopCoroutine("LoseTime");
                                objpanel.SetBool("obj_slide", false);
                                line_one = numboftime;
                                marcus_lines = 1;                          
                                picture1.tag = "Picture piece";                       
                                StartCoroutine("nextobj2");
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
                                next_key.SetActive(false);
                                slide.SetBool("start_slide", false);
                                StopCoroutine("LoseTime");
                                objpanel.SetBool("obj_slide", false);
                                line_one = numboftime;
                                marcus_lines = 1;
                                StartCoroutine("nextobj3"); ;
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
                            case 2:
                                next_key.SetActive(false);
                                slide.SetBool("start_slide", false);
                                StopCoroutine("LoseTime");
                                objpanel.SetBool("obj_slide", false);
                                line_one = numboftime;
                                marcus_lines = 1;
                                StartCoroutine("nextobj4");
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
                obj_text.text = "Search the house for clues";
                Inventory_story story = inventory.GetComponent<Inventory_story>();
                story.key_access = true;

                pic.tag = "Empty Picture Frame";

            }
            else if (obj_next < 0)
            {
                StopCoroutine("nextobj");
            }

            if (obj_next2 == 0)
            {
                objpanel.SetBool("obj_slide", true);
                obj_text.text = "Find the first piece";

                objtracker.SetBool("start_obj", true);
            }
            else if (obj_next2 < 0)
            {
                StopCoroutine("nextobj2");
            }

            if (obj_next3 == 0)
            {
                objpanel.SetBool("obj_slide", true);
                obj_text.text = "Put it Back into the Frame";

                objtracker.SetBool("obj_complete", true);
                item_text.text = "1/1 - Picture Piece";
                pic.tag = "Empty Picture Frame";
            }
            else if (obj_next3 < 0)
            {
                StopCoroutine("nextobj3");
            }

            if (obj_next4 == 0)
            {
                objpanel.SetBool("obj_slide", true);
                obj_text.text = "Enter the portal";

                objtracker.SetBool("close_obj", true);
                portal.SetActive(true);

            }
            else if (obj_next4 < 0)
            {
                StopCoroutine("nextobj4");
            }
                
       
        //else if(game_stage == "GameManager1.3")
        //{
        if (line_part == "seventh line")
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
                                lines.text = "Somethings strange going on here I'll try to find the other piece";
                                line_one = numboftime;
                                next_key.SetActive(false);
                                break;
                            case 3:
                                next_key.SetActive(false);
                                slide.SetBool("start_slide", false);
                                StopCoroutine("LoseTime");
                                door3.tag = "Door";                              
                                line_one = numboftime;
                                marcus_lines = 1;
                                StartCoroutine("nextobj5");
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
                                lines.text = "linesssss";
                                line_one = numboftime;
                                next_key.SetActive(false);
                                break;
                            case 3:
                                next_key.SetActive(false);
                                slide.SetBool("start_slide", false);
                                StopCoroutine("LoseTime");
                                door2.tag = "Door";
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
                            next_key.SetActive(false);
                            slide.SetBool("start_slide", false);
                            StopCoroutine("LoseTime");                        
                            line_one = numboftime;
                            marcus_lines = 1;
                            picture2.tag = "Picture piece";
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
                            next_key.SetActive(false);
                            slide.SetBool("start_slide", false);
                            StopCoroutine("LoseTime");
                            objpanel.SetBool("obj_slide", false);
                            line_one = numboftime;
                            marcus_lines = 1;
                            StartCoroutine("nextobj6"); 
                            break;

                        default:

                            break;

                    }
                }
            }
        }
        else if (line_part == "eleventh line")
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
                            next_key.SetActive(false);
                            slide.SetBool("start_slide", false);
                            StopCoroutine("LoseTime");
                            objpanel.SetBool("obj_slide", false);
                            line_one = numboftime;
                            marcus_lines = 1;
                            StartCoroutine("nextobj7");
                            break;

                        default:

                            break;

                    }
                }
            }
        }
        //}
        if (obj_next5 == 0)
        {
               objpanel.SetBool("obj_slide", true);
               obj_text.text = "Find the other piece";

               objtracker.SetBool("start_obj", true);
        }

        if (obj_next6 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "Put it Back into the Frame";

            objtracker.SetBool("obj_complete", true);
            item_text.text = "1/1 - Picture Piece";
            pic.tag = "Empty Picture Frame";
        }
        else if (obj_next6 < 0)
        {
            StopCoroutine("nextobj6");
        }

        if (obj_next7 == 0)
        {
            objpanel.SetBool("obj_slide", true);
            obj_text.text = "line final";

            objtracker.SetBool("close_obj", true);
            portal.SetActive(true);

        }
        else if (obj_next7 < 0)
        {
            StopCoroutine("nextobj7");
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

