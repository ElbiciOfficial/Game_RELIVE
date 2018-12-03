using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class question_script : MonoBehaviour {

    public Animator loadscreen;
    public Animator rid;
    public Animator slide_txt;

    public Button button_;
    public Button button_2;

    public Animator button_slider;
    public Animator button_slider2;
    private Animator button_anim;
    private Animator button_anim2;

    public Text question;

    private int start_slide = 4;
    private int end_slide = 4;
    private int start_second = 3;
    private int start_third = 3;
    private int start_fourth = 3;
    private int start_fifth = 3;

    private int start_answer = 2;

    private int count_slide;
    private int answer_slide;
    private int oneshot;

    public int numberofright;
    public int numberofwrong;
    private int portal_count = 3;
    private int portal_count2 = 3;

    public GameObject scene_;
    private string stage_type;
    public GameObject final_scene;
    public Text no_button;
    public Text yes_button;

    public GameObject Game_data;

    // Use this for initialization
    void Start () {

        Game_data = GameObject.Find("Game_data");
        loadscreen.SetBool("open", true);
        Cursor.lockState = CursorLockMode.Locked;

        scene_ = GameObject.Find("current_scene");
        scene_name c_name = scene_.GetComponent<scene_name>();
        scene_name f_name = final_scene.GetComponent<scene_name>();
        stage_type = c_name.Name_s;
        oneshot = 1;
        button_anim = button_.GetComponent<Animator>();
        button_anim2 = button_2.GetComponent<Animator>();

        if(stage_type == "Chapter1_stage4")
        {
            f_name.Name_s = "Chapter1_stage5";
            Debug.Log(f_name.Name_s);
        }
        else if (stage_type == "Chapter2_stage4")
        {
            f_name.Name_s = "Chapter2_stage5";
        }
        else if (stage_type == "Chapter3_stage4")
        {
            f_name.Name_s = "Chapter3_stage5";
        }
      
    }
	
    public void addpoint(bool answer)
    {
        if (stage_type == "Chapter1_stage4")
        {
            numberofwrong+= 1;
        }
        else if (stage_type == "Chapter2_stage4")
        {
            numberofright += 1;
        }
        else if (stage_type == "Chapter3_stage4")
        {
            numberofwrong += 1;
        }
       
        //Debug.Log(numberofright);
        button_.interactable = false;
        button_2.interactable = false;

        button_slider.SetBool("start", false);
        button_slider2.SetBool("start", false);
        button_anim.SetBool("start", false);
        button_anim2.SetBool("start", false);

        slide_txt.SetBool("slide_txt", false);
        StartCoroutine("answered_slider");

    }
    public void addpoint2(bool answer)
    {
        if (stage_type == "Chapter1_stage4")
        {
            numberofright += 1;
        }
        else if (stage_type == "Chapter2_stage4")
        {
            numberofwrong += 1;
        }
        else if (stage_type == "Chapter3_stage4")
        {
            numberofright += 1;
        }
           
        button_.interactable = false;
        button_2.interactable = false;

        button_slider.SetBool("start", false);
        button_slider2.SetBool("start", false);
        button_anim.SetBool("start", false);
        button_anim2.SetBool("start", false);

        slide_txt.SetBool("slide_txt", false);
        StartCoroutine("answered_slider");

    }

    // Update is called once per frame
    void Update () {

        game_data game = Game_data.GetComponent<game_data>();
        game.numright += numberofright;
        game.numwrong += numberofwrong;

        if (oneshot == 1)
        {
            if (loadscreen.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !loadscreen.IsInTransition(0))
            {
                rid.SetBool("rid", true);
                StartCoroutine("slider");
                oneshot = 0;
            }
          
        }
        if(stage_type == "Chapter1_stage4")
        {
            if (start_slide == 0)
            {
                if (count_slide == 0)
                {
                    question.text = "I'm gonna ask you a simple question, Mr. Marcus.";
                    slide_txt.SetBool("slide_txt", true);
                    StopCoroutine("slider");
                    count_slide += 1;
                    start_slide = 4;
                    StartCoroutine("slider");
                }
                else if (count_slide == 1)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("second_slider");
                }
                else if (count_slide == 2)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("third_slider");
                }
                else if (count_slide == 3)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("fourth_slider");
                }

            }


            if (start_second == 0)
            {
                question.text = "what if you had the chance, would you change something in the history,..";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_second = 3;
                StartCoroutine("slider");
                StopCoroutine("second_slider");
            }
            else if (start_third == 0)
            {
                question.text = "risking that your parents never will meet with each other and you will never be born?";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_third = 3;
                StartCoroutine("slider");
                StopCoroutine("third_slider");
            }
            else if (start_fourth == 0)
            {
                question.text = "Would you take it or not?";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_fourth = 3;
                StartCoroutine("slider");
                StopCoroutine("fourth_slider");
                button_.interactable = true;
                button_2.interactable = true;
                button_slider.SetBool("start", true);
                button_slider2.SetBool("start", true);
                button_anim.SetBool("start", true);
                button_anim2.SetBool("start", true);
                Cursor.lockState = CursorLockMode.None;
            }
            else if (start_answer == 0)
            {              
                question.text = "Let's see if you've made the right answer. For now I'll leave you on your own";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                answer_slide += 1;
                end_slide = 3;
                start_answer = 3;
                StartCoroutine("eslider");
                StopCoroutine("answered_slider");
            }

            if (end_slide == 0)
            {
                if (answer_slide == 1)
                {
                    slide_txt.SetBool("slide_txt", false);
                    rid.SetBool("rid", false);
                    loadscreen.SetBool("load", true);
                    loadscreen.SetBool("open", false);
                    StartCoroutine("load1");
                    //SceneManager.LoadScene("chapter2_stage1");
                }

            }
        }
        else if (stage_type == "Chapter2_stage4")
        {
            if (start_slide == 0)
            {
                if (count_slide == 0)
                {
                    yes_button.text = "Give up everything for my parents";
                    no_button.text = "Don't accept it";

                    question.text = "So we meet again Marcus.";
                    slide_txt.SetBool("slide_txt", true);
                    StopCoroutine("slider");
                    count_slide += 1;
                    start_slide = 4;
                    StartCoroutine("slider");
                }
                else if (count_slide == 1)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("second_slider");
                }
                else if (count_slide == 2)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("third_slider");
                }
                else if (count_slide == 3)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("fourth_slider");
                }

            }


            if (start_second == 0)
            {
                question.text = "As for your second question, Knowing that you don't have a perfect relationship with your parents.";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_second = 3;
                StartCoroutine("slider");
                StopCoroutine("second_slider");
            }
            else if (start_third == 0)
            {
                question.text = "Still, what is more important to you? The love and lessons that your parents gave you,";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_third = 3;
                StartCoroutine("slider");
                StopCoroutine("third_slider");
                no_button.text = "";
                yes_button.text = "";
            }
            else if (start_fourth == 0)
            {
                question.text = "or your most priced possessions?";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_fourth = 3;
                StartCoroutine("slider");
                StopCoroutine("fourth_slider");
                button_.interactable = true;
                button_2.interactable = true;
                button_slider.SetBool("start", true);
                button_slider2.SetBool("start", true);
                button_anim.SetBool("start", true);
                button_anim2.SetBool("start", true);
                Cursor.lockState = CursorLockMode.None;
            }
            else if (start_answer == 0)
            {
                question.text = "Let's see if you've made the right answer. For now I'll leave you on your own";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                answer_slide += 1;
                end_slide = 3;
                start_answer = 3;
                StartCoroutine("eslider");
                StopCoroutine("answered_slider");
            }

            if (end_slide == 0)
            {
                if (answer_slide == 1)
                {
                    slide_txt.SetBool("slide_txt", false);
                    rid.SetBool("rid", false);
                    loadscreen.SetBool("load", true);
                    loadscreen.SetBool("open", false);
                    StartCoroutine("load1");
                    //SceneManager.LoadScene("chapter2_stage1");
                }

            }
        }
        else if (stage_type == "Chapter3_stage4")
        {
            if (start_slide == 0)
            {
                if (count_slide == 0)
                {
                    yes_button.text = "Don't accept it";
                    no_button.text = "Give up everything for my parents";
                   

                    question.text = "You've come a long way Marcus, It's been a tough journey but everything that has a beginning, has an ending.";
                    slide_txt.SetBool("slide_txt", true);
                    StopCoroutine("slider");
                    count_slide += 1;
                    start_slide = 4;
                    StartCoroutine("slider");
                }
                else if (count_slide == 1)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("second_slider");
                }
                else if (count_slide == 2)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("third_slider");
                }
                else if (count_slide == 3)
                {
                    slide_txt.SetBool("slide_txt", false);
                    StartCoroutine("fourth_slider");
                }

            }


            if (start_second == 0)
            {
                question.text = "Now for your final decision that will determine the outcome of all your choices. given the possibility,";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_second = 3;
                StartCoroutine("slider");
                StopCoroutine("second_slider");
            }
            else if (start_third == 0)
            {
                question.text = "would you give up your fame, wealth and everything that you built up";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_third = 3;
                StartCoroutine("slider");
                StopCoroutine("third_slider");
            }
            else if (start_fourth == 0)
            {
                question.text = "throughout your entire life in exchange of meeting";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_fourth = 3;
                StartCoroutine("slider");
                StopCoroutine("third_slider");
                no_button.text = "";
                yes_button.text = "";
            }
            else if (start_fifth == 0)
            {
                question.text = " and talking to your parents again?";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                count_slide += 1;
                start_slide = 4;
                start_fifth = 3;
                StartCoroutine("slider");
                StopCoroutine("fourth_slider");
                button_.interactable = true;
                button_2.interactable = true;
                button_slider.SetBool("start", true);
                button_slider2.SetBool("start", true);
                button_anim.SetBool("start", true);
                button_anim2.SetBool("start", true);
                Cursor.lockState = CursorLockMode.None;
            }
            else if (start_answer == 0)
            {
                question.text = "You're in your final journey now, Mr. Marcus, your choices define you. You're on your own now, be brave and face the consequences. Goodbye.";
                slide_txt.SetBool("slide_txt", true);
                StopCoroutine("slider");
                answer_slide += 1;
                end_slide = 3;
                start_answer = 3;
                StartCoroutine("eslider");
                StopCoroutine("answered_slider");
            }

            if (end_slide == 0)
            {
                if (answer_slide == 1)
                {
                    slide_txt.SetBool("slide_txt", false);
                    rid.SetBool("rid", false);
                    loadscreen.SetBool("load", true);
                    loadscreen.SetBool("open", false);
                    StartCoroutine("load2");
                    //SceneManager.LoadScene("chapter2_stage1");
                }

            }
        }

        if (portal_count == 0)
        {
            DontDestroyOnLoad(Game_data);
            Destroy(scene_);
            DontDestroyOnLoad(final_scene);
            SceneManager.LoadScene("Storyline");
        }

        if (portal_count2 == 0)
        {
            DontDestroyOnLoad(Game_data);
            Destroy(scene_);
            //DontDestroyOnLoad(final_scene);
            SceneManager.LoadScene("ending");
        }

    }

    IEnumerator slider()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            start_slide--;



        }
    }
    IEnumerator eslider()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


           end_slide--;



        }
    }
    IEnumerator second_slider()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            start_second--;



        }
    }
    IEnumerator third_slider()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            start_third--;



        }
    }
    IEnumerator fourth_slider()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            start_fourth--;



        }
    }
    IEnumerator fifth_slider()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            start_fifth--;



        }
    }
    IEnumerator answered_slider()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            start_answer--;



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
    IEnumerator load2()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            portal_count2--;



        }
    }
}
