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

    // Use this for initialization
    void Start()
    {

        Button strt = skipbutton.GetComponent<Button>();
        strt.onClick.AddListener(ToggleSkip);
    }
    public void ToggleSkip()
    {
        story_line st = story.GetComponent<story_line>();

        game_scene = st.stage_type;

        skipbutton.interactable = false;
        button.SetBool("slide_skip", false);
        load.SetBool("load", true);

        StartCoroutine("load1");

    }
    // Update is called once per frame
    void Update () {

        if (portal_count == 0)
        {
            if (game_scene == "newgame")
            {
                StopCoroutine("load1");
                SceneManager.LoadScene("chapter1_stage1");

            }
            else if (game_scene == "Chapter1_stage5")
            {
                StopCoroutine("load1");
                SceneManager.LoadScene("chapter2_stage1");

            }
            //else if (story_scene == "Chapter2_stage5")
            //{
            //   
            //        display_story.sprite = chapter3[count2];
            // 
            //}

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
