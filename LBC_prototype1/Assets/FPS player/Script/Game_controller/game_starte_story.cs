using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_starte_story : MonoBehaviour {

    public string stage;
    public GameObject GameEndPanel;
 
    public GameObject Countdown;
    public GameObject gameStart;
    public Text starttext;
    public Text counttext;
    private int Counter = 0;
    bool timestarts = false;
    public GameObject Objectivespanel;
    public GameObject startpanel;

    public GameObject[] UIlist = new GameObject[6];
    private Animator a;
    int oneshot;
    public Button startbutton;
    public Animator loadsreen;
 

    void Start()
    {
        loadsreen.SetBool("open", true);
        Cursor.lockState = CursorLockMode.None;     
        a = Objectivespanel.GetComponent<Animator>();
        a.SetBool("start", true);
        oneshot = 1;    
        for (int i = 0; i < UIlist.Length; i++)
        {
            UIlist[i].SetActive(false);
        }
        //Just making sure that the timeScale is right             
    }

    public void startgame(bool start)
    {
        Time.timeScale = 1;
        Objectivespanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        //Countdown.SetActive(true);
        //StartCoroutine("LoseTime");
        Counter = 1;
       
    }

    public void DoFreeze()
    {
        var original = Time.timeScale;
        Time.timeScale = 0f;
    }

   

    void Update()
    {
        stage = gameObject.name.ToString();

        if (oneshot == 1)
        {
            if (a.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !a.IsInTransition(0))
            {
                startbutton.interactable = true;
                DoFreeze();
                startpanel.SetActive(true);
                oneshot = 0;
            }
        }



        if (Counter == 1)
        {
            for (int i = 0; i < UIlist.Length; i++)
            {
                UIlist[i].SetActive(true);
            }
            Counter = 0;
            //Countdown.SetActive(false);
            //timestarts = true;
            // gameStart.SetActive(true);

        }

    }

    //IEnumerator LoseTime()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1);
    //        Counter--;
    //        if (timestarts == true)
    //        {
    //            gameStart.SetActive(false);

    //        }

    //    }
    //}
}


