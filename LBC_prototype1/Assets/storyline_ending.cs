using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class storyline_ending : MonoBehaviour {

    public Sprite[] ending1 = new Sprite[15];
    public Sprite[] ending2 = new Sprite[14];

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
    void Start()
    {
        Game_data = GameObject.Find("Game_data");
        game_data game = Game_data.GetComponent<game_data>();

        Cursor.lockState = CursorLockMode.Locked;
        if (game.numright > game.numwrong)
        {
            stage_type = "ending_route1";

        }
        else if (game.numright < game.numwrong)
        {
            stage_type = "ending_route2";
        }

        if (stage_type == "ending_route1")
        {
            play_bgm.clip = bgm1[0];
            play_bgm.Play();
            story_scene = "Ending1_story";
            StartCoroutine("nextscene");
            StartCoroutine("startskip");
        }
        else if (stage_type == "ending_route2")
        {
            play_bgm.clip = bgm1[1];
            play_bgm.Play();
            story_scene = "Ending2_story";
            StartCoroutine("nextscene");
            StartCoroutine("startskip");
        }
     
    }

    // Update is called once per frame
    void Update()
    {

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

            if (story_scene == "Ending1_story")
            {
                if (count2 == ending1.Length)
                {
                    count = 3;
                    secount = 5;
                    StopCoroutine("nextscene2");
                    StopCoroutine("nextscene");
                    StartCoroutine("load1");
                }
            }
            else if (story_scene == "Ending2_story")
            {
                if (count2 == ending2.Length)
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

            if (story_scene == "Ending1_story")
            {
                if (count2 < ending1.Length)
                {
                    display_story.sprite = ending1[count2];
                }
            }
            else if (story_scene == "Ending2_story")
            {
                if (count2 < ending2.Length)
                {
                    display_story.sprite = ending2[count2];
                }
            }
            
            count = 3;
            StartCoroutine("nextscene2");

        }

        //}
        if (portal_count == 0)
        {
            if (story_scene == "Ending1_story")
            {
                if (count2 == ending1.Length)
                {
                    Destroy(scene_);
                    SceneManager.LoadScene("MainMenu");
                }
            }
            else if (story_scene == "Ending2_story")
            {
                if (count2 == ending2.Length)
                {
                    Destroy(scene_);
                    SceneManager.LoadScene("MainMenu");
                }
            }

        }

        //if (skip_count == 0)
        //{

        //    Cursor.lockState = CursorLockMode.None;
        //    skip.interactable = true;
        //    Animator skip1 = skip.GetComponent<Animator>();
        //    skip1.SetBool("slide_skip", true);
        //}

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
