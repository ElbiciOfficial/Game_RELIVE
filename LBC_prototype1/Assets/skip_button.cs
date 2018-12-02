using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skip_button : MonoBehaviour {

    public Button skipbutton;
    public Animator load;
    public Animator button;
    public string game_scene;
    public GameObject story;

    private int portal_count = 3;

    public GameObject scene_;
    public GameObject Game_data;

    // Use this for initialization
    void Start()
    {
        Game_data = GameObject.Find("Game_data");
        scene_ = GameObject.Find("scene name");
        scene_name f_name = scene_.GetComponent<scene_name>();
        game_scene = f_name.Name_s;
        Button strt = skipbutton.GetComponent<Button>();
        strt.onClick.AddListener(ToggleSkip);
    }
    public void ToggleSkip()
    {
        //story_line st = story.GetComponent<story_line>();

       
        skipbutton.interactable = false;
        button.SetBool("slide_skip", false);
        load.SetBool("load", true);
        load.SetBool("open", false);

        StartCoroutine("load1");

    }
    // Update is called once per frame
    void Update () {

        if (portal_count == 0)
        {
            if (game_scene == "newgame")
            {
                DontDestroyOnLoad(Game_data);
                Destroy(scene_);
                StopCoroutine("load1");
                SceneManager.LoadScene("chapter1_stage1");

            }
            else if (game_scene == "Chapter1_stage5")
            {
                DontDestroyOnLoad(Game_data);
                Destroy(scene_);
                StopCoroutine("load1");
                SceneManager.LoadScene("chapter2_stage1");

            }
            else if (game_scene == "Chapter2_stage5")
            {
                DontDestroyOnLoad(Game_data);
                Destroy(scene_);
                StopCoroutine("load1");
                SceneManager.LoadScene("chapter3_stage1");

            }
            else if (game_scene == "chapter3_stage1")
            {
                DontDestroyOnLoad(Game_data);
                DontDestroyOnLoad(scene_);
                StopCoroutine("load1");
                SceneManager.LoadScene("chapter1_stage2");

            }
            else if (game_scene == "chapter3_stage3")
            {
                DontDestroyOnLoad(Game_data);
                DontDestroyOnLoad(scene_);
                StopCoroutine("load1");
                SceneManager.LoadScene("chapter1_stage2");

            }

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
}
