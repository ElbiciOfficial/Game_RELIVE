using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class story_line : MonoBehaviour {

    public Sprite[] chapter1 = new Sprite[15];
    public Sprite[] chapter2 = new Sprite[14];
    public Sprite[] chapter3 = new Sprite[16];

    public Sprite[] chapter3mini = new Sprite[2];
    public Sprite[] chapter3mini2 = new Sprite[2];

    public AudioSource play_bgm;
    public AudioClip[] bgm1;

    public Animator loadscreen;
    public Image display_story;

    public int secount = 5;
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

 

    public GameObject Game_data;
    // Use this for initialization
    void Start () {

        Game_data = GameObject.Find("Game_data");
        scene_ = GameObject.Find("scene name");
        scene_name f_name = scene_.GetComponent<scene_name>();
        //scene_name t_name = story_scene.GetComponent<scene_name>();
        Cursor.lockState = CursorLockMode.Locked;
        stage_type = f_name.Name_s;

        //AudioSource audio = GetComponent<AudioSource>();

        if (stage_type == "newgame")
        {
            play_bgm.clip = bgm1[0];
            play_bgm.Play();
            story_scene = "Chapter1_story";
            StartCoroutine("nextscene");
            StartCoroutine("startskip");

        }
        else if (stage_type == "Chapter1_stage5")
        {
            play_bgm.clip = bgm1[1];
            play_bgm.Play();
            story_scene = "Chapter2_story";
            StartCoroutine("nextscene");
            StartCoroutine("startskip");

        }
        else if (stage_type == "Chapter2_stage5")
        {
            play_bgm.clip = bgm1[2];
            play_bgm.Play();
            story_scene = "Chapter3_story";
           StartCoroutine("nextscene");
           StartCoroutine("startskip");
        }
        else if (stage_type == "chapter3_stage1")
        {
            play_bgm.clip = bgm1[3];
            play_bgm.Play();
            story_scene = "Chapter3_1";
            StartCoroutine("nextscene");
            StartCoroutine("startskip");
        }
        else if (stage_type == "chapter3_stage3")
        {
            play_bgm.clip = bgm1[4];
            play_bgm.Play();
            story_scene = "Chapter3_3";
            StartCoroutine("nextscene");
            StartCoroutine("startskip");
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
                secount = 5;
                StopCoroutine("nextscene2");
                StartCoroutine("nextscene");

                if (story_scene == "Chapter1_story")
                {
                    if (count2 == chapter1.Length)
                    {
                        count = 3;
                        secount = 5;
                        StopCoroutine("nextscene2");
                        StopCoroutine("nextscene");
                        StartCoroutine("load1");
                    }
                }
                else if (story_scene == "Chapter2_story")
                {
                    if (count2 == chapter2.Length)
                    {
                        count = 3;
                        secount = 5;
                        StopCoroutine("nextscene2");
                        StopCoroutine("nextscene");
                        StartCoroutine("load1");
                    }
                }
                else if (story_scene == "Chapter3_story")
                {
                    if (count2 == chapter3.Length)
                    {
                        count = 3;
                        secount = 5;
                        StopCoroutine("nextscene2");
                        StopCoroutine("nextscene");
                        StartCoroutine("load1");
                    }
                }
                else if (story_scene == "Chapter3_1")
                {
                    if (count2 == chapter3mini.Length)
                    {
                        count = 3;
                        secount = 5;
                        StopCoroutine("nextscene2");
                        StopCoroutine("nextscene");
                        StartCoroutine("load1");
                    }
                }
                else if (story_scene == "Chapter3_3")
                {
                    if (count2 == chapter3mini2.Length)
                    {
                        count = 3;
                        secount = 5;
                        StopCoroutine("nextscene2");
                        StopCoroutine("nextscene");
                        StartCoroutine("load1");
                    }
                }


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
                else if (story_scene == "Chapter3_story")
                {
                    if (count2 < chapter3.Length)
                    {
                        display_story.sprite = chapter3[count2];
                    }
                }
                else if (story_scene == "Chapter3_1")
                {
                    if (count2 < chapter3mini.Length)
                    {
                        display_story.sprite = chapter3mini[count2];
                    }
                }
                else if (story_scene == "Chapter3_3")
                {
                    if (count2 < chapter3mini2.Length)
                    {
                        display_story.sprite = chapter3mini2[count2];
                    }
                }

                count = 3;
                StartCoroutine("nextscene2");

            }

        //}
        if (portal_count == 0)
        {
            if (story_scene == "Chapter1_story")
            {
                if (count2 == chapter1.Length)
                {
                    DontDestroyOnLoad(Game_data);
                    Destroy(scene_);
                    SceneManager.LoadScene("chapter1_stage1");
                }
            }
            else if (story_scene == "Chapter2_story")
            {
                if (count2 == chapter2.Length)
                {
                    DontDestroyOnLoad(Game_data);
                    Destroy(scene_);
                    SceneManager.LoadScene("chapter2_stage1");
                }
            }
            else if (story_scene == "Chapter3_story")
            {
                if (count2 == chapter3.Length)
                {
                    DontDestroyOnLoad(Game_data);
                    Destroy(scene_);
                    SceneManager.LoadScene("chapter3_stage1");
                }
            }
            else if (story_scene == "Chapter3_1")
            {
                if (count2 == chapter3mini.Length)
                {
                    DontDestroyOnLoad(Game_data);
                    DontDestroyOnLoad(scene_);
                    SceneManager.LoadScene("chapter1_stage2");
                }
            }
            else if (story_scene == "Chapter3_3")
            {
                if (count2 == chapter3mini2.Length)
                {
                    DontDestroyOnLoad(Game_data);
                    DontDestroyOnLoad(scene_);
                    SceneManager.LoadScene("chapter1_stage2");
                }
            }
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
