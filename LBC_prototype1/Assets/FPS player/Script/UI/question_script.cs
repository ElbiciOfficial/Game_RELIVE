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

    private int start_answer = 2;

    private int count_slide;
    private int answer_slide;
    private int oneshot;

    public int numberofright;
    public int numberofwrong;
    private int portal_count = 3;

    public GameObject scene_;
    private string stage_type;
    public GameObject final_scene;

    // Use this for initialization
    void Start () {

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
        }
        else if (stage_type == "Chapter2_stage4")
        {
            f_name.Name_s = "Chapter2_stage5";
        }
        else if (stage_type == "Chaoter3_stage4")
        {
            f_name.Name_s = "Chapter3_stage5";
        }
      
    }
	
    public void addpoint(bool answer)
    {
        numberofright += 1;
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
        numberofwrong += 1;
     
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
                    question.text = "Oh we meet again, Mr. Marcus.";
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
                question.text = "Don't be nervous, I just want to ask you another question.";
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
                question.text = "Do you want to blah blah blah";
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

        if (portal_count == 0)
        {
            Destroy(scene_);
            DontDestroyOnLoad(final_scene);
            SceneManager.LoadScene("Storyline");
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
}
