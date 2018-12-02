using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_button : MonoBehaviour {

    public GameObject gamemanager;
    public Button nextbutton;
    public GameObject startpanel;
    private int portal_count = 3;
    public Animator loadscene;
    public Animator result;
    public GameObject currentS;
    void Start()
    {
       
        Button strt = nextbutton.GetComponent<Button>();
        strt.onClick.AddListener(ToggleStart);
    }
    public void ToggleStart()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        game_starter start = gamemanager.GetComponent<game_starter>();
        startpanel.SetActive(false);

        if (start.p_died == true || start.p_failed == true)
        {         
            result.SetBool("result_close", true);
            loadscene.SetBool("load", true);
            loadscene.SetBool("open", false);
            StartCoroutine("loadscreen");
        }
        else if (start.p_succeed == true)
        {
            result.SetBool("result_close", true);
            loadscene.SetBool("load", true);
            loadscene.SetBool("open", false);
            StartCoroutine("loadscreen");
                   
        }
    }
    void Update()
    {
        game_starter start = gamemanager.GetComponent<game_starter>();

        if (start.p_died == true || start.p_failed == true)
        {
            if (portal_count == 0)
            {
                start.scenereload(true);
                start.startgame(true);
            }
           
        }     
        else if (start.stage_type == "chapter1_stage1")
        {
            
            if (portal_count == 0)
            {
                SceneManager.LoadScene("chapter1_stage3");
            }
        }
        else if (start.stage_type == "chapter1_stage3")
        {

            if (portal_count == 0)
            {
                DontDestroyOnLoad(currentS);
                SceneManager.LoadScene("stage5");
            }
        }
        else if (start.stage_type == "chapter2_stage1")
        {
            if (portal_count == 0)
            {
                SceneManager.LoadScene("chapter2_stage3");
            }
        }
        else if (start.stage_type == "chapter2_stage3")
        {
            if (portal_count == 0)
            {
                DontDestroyOnLoad(currentS);
                SceneManager.LoadScene("stage5");
            }
        }
        else if (start.stage_type == "chapter3_stage1")
        {
            if (portal_count == 0)
            {              
                SceneManager.LoadScene("chapter3_stage3");
            }
        }
        else if (start.stage_type == "chapter3_stage4")
        {
            if (portal_count == 0)
            {
                DontDestroyOnLoad(currentS);
                SceneManager.LoadScene("stage5");
            }
        }
    }
    IEnumerator loadscreen()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            portal_count--;



        }
    }
}
