
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    //public GameObject PauseMenuUI;
    public Animator menuslide;
    private int oneshot = 2;
    private int count;
    public KeyCode esc;
    public GameObject startpanel;

    public GameObject menupanel;
    private int twoshot;
    public bool menu_panel;
    // Update is called once per frame
    void Update () {

        if(menu_panel == true)
        {
            if (Input.GetKeyDown(esc))
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }

            }
        }
       

        if (oneshot == 1)
        {         
            startpanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            DoFreeze();
            GameIsPaused = true;
            count = 0;
            oneshot = 2;
            StopCoroutine("LoseTime");
            GameIsPaused = true;
        }

              
    }

    public void DoFreeze()
    {
        var original = Time.timeScale;
        Time.timeScale = 0f;
    }

    //public void resumebtn(bool re)
    //{
      
    //    startpanel.SetActive(false);
    //    Time.timeScale = 1;
    //    Cursor.lockState = CursorLockMode.Locked;
    //    menuslide.SetBool("menu", false);
       
    //}

    void Resume()
    {
        startpanel.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        twoshot = 1;
        menuslide.SetBool("menu", false);
        GameIsPaused = false;
    }

    void Pause()
    {
        menuslide.SetBool("menu", true);
        StartCoroutine("LoseTime");
        count = 1;
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            oneshot--;



        }
    }
}
