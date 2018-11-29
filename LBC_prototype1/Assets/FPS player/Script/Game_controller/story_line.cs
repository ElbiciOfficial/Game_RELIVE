using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class story_line : MonoBehaviour {

    public Sprite[] chapter1 = new Sprite[15];
    public Sprite[] chapter2 = new Sprite[13];
    public Animator loadscreen;
    public Image display_story;

    public int secount = 3;
    public int count = 3;
    private int count2 = 0;

    //public GameObject new_game;
    //public string newg;

    public GameObject black;

    public GameObject scene_;
    public string stage_type;
    private string story_scene;

    private int portal_count = 3;

    private int skip_count = 9;
    public Button skip;

    // Use this for initialization
    void Start () {

        scene_ = GameObject.Find("final_scene");
        scene_name f_name = scene_.GetComponent<scene_name>();
        //scene_name t_name = story_scene.GetComponent<scene_name>();
        Cursor.lockState = CursorLockMode.Locked;
        stage_type = f_name.Name_s;
        StartCoroutine("nextscene");
        StartCoroutine("startskip");

        if (stage_type == "newgame")
        {
            story_scene = "Chapter1_story";
        }
        else if (stage_type == "Chapter1_stage5")
        {
            story_scene = "Chapter2_story";
        }
        else if (stage_type == "Chapter2_stage5")
        {
           story_scene = "Chapter3_story";
        }
    }
	
	// Update is called once per frame
	void Update () {

        //if (newg == "newgame")
        //{
            if (secount == 1)
            {
                loadscreen.SetBool("load", true);
                loadscreen.SetBool("open", false);
                count2 += 1;
                secount = 3;
                StopCoroutine("nextscene2");
                StartCoroutine("nextscene");

                if (story_scene == "Chapter1_story")
                {
                    if (count2 == chapter1.Length - 1)
                    {
                        count = 3;
                        secount = 3;
                        StopCoroutine("nextscene2");
                        StopCoroutine("nextscene");
                        StartCoroutine("load1");
                    }
                }
                else if (story_scene == "Chapter2_story")
                {
                    if (count2 == chapter2.Length - 1)
                    {
                        count = 3;
                        secount = 3;
                        StopCoroutine("nextscene2");
                        StopCoroutine("nextscene");
                        StartCoroutine("load1");
                    }
                }
                //else if (story_scene == "Chapter3_story")
                //{
                //    if (count2 < chapter1.Length)
                //    {
                //        display_story.sprite = chapter3[count2];
                //    }
                //}
           

            }
            else if (count == 0)
            {
                loadscreen.SetBool("load", false);
                black.SetActive(false);
                loadscreen.SetBool("open", true);
                StopCoroutine("nextscene");

                if (story_scene == "Chapter1_story")
                {
                    if (count2 < chapter1.Length)
                    {
                        display_story.sprite = chapter1[count2];
                    }
                }
                else if (story_scene == "Chapter2_story")
                {
                    if (count2 < chapter2.Length)
                    {
                        display_story.sprite = chapter2[count2];
                    }
                }
                //else if (story_scene == "Chapter3_story")
                //{
                //    if (count2 < chapter1.Length)
                //    {
                //        display_story.sprite = chapter3[count2];
                //    }
                //}

                count = 4;
                StartCoroutine("nextscene2");

            }

        //}
        if (portal_count == 0)
        {
            if (story_scene == "Chapter1_story")
            {
                if (count2 == chapter1.Length - 1)
                {
                    SceneManager.LoadScene("chapter1_stage1");
                }
            }
            else if (story_scene == "Chapter2_story")
            {
                if (count2 == chapter2.Length - 1)
                {
                    SceneManager.LoadScene("chapter2_stage1");
                }
            }
            //else if (story_scene == "Chapter3_story")
            //{
            //    if (count2 < chapter1.Length)
            //    {
            //        display_story.sprite = chapter3[count2];
            //    }
            //}

        }

        if(skip_count == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            skip.interactable = true;
            Animator skip1 = skip.GetComponent<Animator>();
            skip1.SetBool("slide_skip", true);
        }

    }


    IEnumerator nextscene()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            count--;



        }
    }
    IEnumerator nextscene2()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            secount--;



        }
    }
    IEnumerator load1()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            portal_count--;



        }
    }
    IEnumerator startskip()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            skip_count--;



        }
    }
}
