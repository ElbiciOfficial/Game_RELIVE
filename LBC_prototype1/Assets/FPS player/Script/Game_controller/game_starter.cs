using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_starter : MonoBehaviour
{
    public string[] stages = new string[6];
    public Text killed;
    public Text obj_result;

    public Text obj_title;
    public Text obj_sub;
    public Text obj_button;


    private GameObject[] numofenemy;

    public GameObject countdown;
    public Text cdtime;
    public GameObject GameEndPanel;

    public int numberofspawn;
        
    public GameObject enemyspawn1;
    public GameObject enemyspawn2;
    public GameObject enemyspawn3;
    public GameObject enemyspawn4;
    public GameObject enemyspawn5;
    public GameObject enemyspawn6;

    public GameObject Countdown;
    public GameObject gameStart;
    public Text starttext;
    public Text counttext;
    private int Counter = 5;
    bool timestarts = false;
    public GameObject cdtimepanel;
    public GameObject markerpanel;
    public GameObject inventorypanel;
    public GameObject Objectivespanel;
    public GameObject startpanel;
    private Animator a;
    private Animator b;
    private Animator c;
    private Animator d;

    private Animator result;

    public int oneshot;

    public GameObject[] UIlist = new GameObject[6];

    public GameObject[] respawns;

    public Camera playerc;
    public GameObject weapon;
    public player_info Player_health;
    public bool p_died = false;
    public bool p_failed = false;
    public bool p_succeed = false;

    public Button startbutton;
    public Button nextbutton;

    public Animator loadscreen;
    public string stage_type;
    public float timeLeft;

    public Text stage_chapter;
    public Text stage_title;
    public Text stage_objective;

    public Text marker_objective;
    public GameObject scene_;
    public GameObject current_scene;

    public GameObject group1;
    public GameObject group2;

    public GameObject dialogue;
    public GameObject player;

    void Start()
    {     
        scene_ = GameObject.Find("scene name");
        scene_name s_name = scene_.GetComponent<scene_name>();
        scene_name c_name =current_scene.GetComponent<scene_name>();
        stage_type = s_name.Name_s;
        Debug.Log(stage_type);

        if (stage_type == "chapter1_stage1")
        {
            timeLeft = 15;


            stage_chapter.text = "Chapter I";
            stage_title.text = "Stage 2";
            stage_objective.text = "Kill 60 Enemies in 2 Minutes and 30 seconds";
            marker_objective.text = stage_objective.text;
            group1.SetActive(true);
        }
        else if (stage_type == "chapter1_stage3")
        {
            timeLeft = 15;

            c_name.Name_s = "Chapter1_stage4";
            stage_chapter.text = "Chapter I";
            stage_title.text = "Stage 4";
            stage_objective.text = "Kill 100 Enemies in 3 Minutes";
            marker_objective.text = stage_objective.text;
            group2.SetActive(true);
        }
        else if (stage_type == "chapter2_stage1")
        {
            timeLeft = 15;


            stage_chapter.text = "Chapter II";
            stage_title.text = "Stage 2";
            stage_objective.text = "Kill 60 Enemies in 2 Minutes and 30 seconds";
            marker_objective.text = stage_objective.text;
        }
        else if (stage_type == "chapter2_stage3")
        {
            timeLeft = 15;

            c_name.Name_s = "Chapter2_stage4";
            stage_chapter.text = "Chapter II";
            stage_title.text = "Stage 4";
            stage_objective.text = "Kill 100 Enemies in 3 Minutes";
            marker_objective.text = stage_objective.text;
        }

        loadscreen.SetBool("open", true);
        Cursor.lockState = CursorLockMode.None;
        a = Objectivespanel.GetComponent<Animator>();
        result = GameEndPanel.GetComponent<Animator>();
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
        dialogue_chapter1 story = dialogue.GetComponent<dialogue_chapter1>();
        story.story_part(true);
        //Debug.Log("PAUSE");
    }

    public void count_down(bool count)
    {
        Countdown.SetActive(true);
        StartCoroutine("LoseTime");
    }

    public void DoFreeze()
    {
        var original = Time.timeScale;
        Time.timeScale = 0f;
    }


    void Update()
    {
        if(Player_health.player_health == 0 && p_died == false)
        {
            p_died = true;
            GameOver();       
        }
       

        if (oneshot == 1)
        {
            if (a.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !a.IsInTransition(0))
            {
                startbutton.interactable = true;
                DoFreeze();
                startpanel.SetActive(true);
                oneshot = 0;
            }else if(result.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !result.IsInTransition(0))
            {
                nextbutton.interactable = true;
                DoFreeze();
                startpanel.SetActive(true);
                oneshot = 0;
            }

        }

        if(Counter != -1)
        {
            counttext.text = Counter.ToString();
        }
        else
        {
            Countdown.SetActive(false);
            gameStart.SetActive(true);
        }
      
        if (Counter == -2)
        {
            for (int i = 0; i < UIlist.Length; i++)
            {
                UIlist[i].SetActive(true);
                        
            }

            //Playermove play = player.GetComponent<Playermove>();
            //play.startmove = true;

            b = cdtimepanel.GetComponent<Animator>();
            b.SetBool("start_cd", true);
            c = markerpanel.GetComponent<Animator>();
            c.SetBool("start_marker", true);
            d = inventorypanel.GetComponent<Animator>();
            d.SetBool("start_inventory", true);
         
            timestarts = true;


            enemy_spawn enemy1 = enemyspawn1.GetComponent<enemy_spawn>();
            enemy_spawn enemy2 = enemyspawn2.GetComponent<enemy_spawn>();
            enemy_spawn enemy3 = enemyspawn3.GetComponent<enemy_spawn>();
            enemy_spawn enemy4 = enemyspawn4.GetComponent<enemy_spawn>();
            enemy_spawn enemy5 = enemyspawn5.GetComponent<enemy_spawn>();
            enemy_spawn enemy6 = enemyspawn6.GetComponent<enemy_spawn>();

            enemy1.startspawn(true);
            enemy2.startspawn(true);
            enemy3.startspawn(true);
            enemy4.startspawn(true);
            enemy5.startspawn(true);
            enemy6.startspawn(true);


            countdown.SetActive(true);
      
        }

        if(Counter < -2)
        {
            numofenemy = GameObject.FindGameObjectsWithTag("Enemy");
            //Debug.Log("Enemy spawn: " + numofenemy.Length);

            if (numofenemy.Length >= numberofspawn)
            {
                enemy_spawn enemy1 = enemyspawn1.GetComponent<enemy_spawn>();
                enemy_spawn enemy2 = enemyspawn2.GetComponent<enemy_spawn>();
                enemy_spawn enemy3 = enemyspawn3.GetComponent<enemy_spawn>();
                enemy_spawn enemy4 = enemyspawn4.GetComponent<enemy_spawn>();
                enemy_spawn enemy5 = enemyspawn5.GetComponent<enemy_spawn>();
                enemy_spawn enemy6 = enemyspawn6.GetComponent<enemy_spawn>();

                enemy1.startspawn(false);
                enemy2.startspawn(false);
                enemy3.startspawn(false);
                enemy4.startspawn(false);
                enemy5.startspawn(false);
                enemy6.startspawn(false);

            }
            else if (numofenemy.Length < numberofspawn)
            {
                enemy_spawn enemy1 = enemyspawn1.GetComponent<enemy_spawn>();
                enemy_spawn enemy2 = enemyspawn2.GetComponent<enemy_spawn>();
                enemy_spawn enemy3 = enemyspawn3.GetComponent<enemy_spawn>();
                enemy_spawn enemy4 = enemyspawn4.GetComponent<enemy_spawn>();
                enemy_spawn enemy5 = enemyspawn5.GetComponent<enemy_spawn>();
                enemy_spawn enemy6 = enemyspawn6.GetComponent<enemy_spawn>();

                enemy1.startspawn(true);
                enemy2.startspawn(true);
                enemy3.startspawn(true);
                enemy4.startspawn(true);
                enemy5.startspawn(true);
                enemy6.startspawn(true);

            }
            Counter = -3;
            StopCoroutine("LoseTime"); 
        }
      
        
        if(timestarts == true)
        {
            if(timeLeft < 0)
            {
                countdown.SetActive(false);
                timeLeft = 0;
                GameOver();
                timestarts = false;
            }
            else if(timeLeft >= 0)
            {
                timeLeft -= Time.deltaTime;
                cdtime.text = timeLeft.ToString("F2");            
            }
           
        }
     

    }

    void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        GameEndPanel.SetActive(true);
        result.SetBool("game_result", true);
        respawns = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject respawn in respawns)
        {
            Destroy(respawn);
        }
        headbob cam = playerc.GetComponent<headbob>();
        cam.freezeit(true);
        oneshot = 1;

        for (int i = 0; i < UIlist.Length; i++)
        {
            UIlist[i].SetActive(false);
        }
        cdtimepanel.SetActive(false);
        markerpanel.SetActive(false);
        inventorypanel.SetActive(false);
        weapon.SetActive(false);

       if(stage_type == "chapter1_stage1")
        {
            if (int.Parse(killed.text) < int.Parse(stages[0]) && p_died != true)
            {
                obj_title.text = "Sad";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else if (p_died == true && int.Parse(killed.text) < int.Parse(stages[0]))
            {
                obj_title.text = "You Died";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else
            {
                obj_title.text = "Good Job";
                obj_sub.text = "Objective Complete";
                obj_button.text = "Next";
                p_succeed = true;
                Destroy(scene_);
            }
            obj_result.text = killed.text + " " + obj_result.text + " " + stages[0];

       }
       else if(stage_type == "chapter1_stage3")
       {
            if (int.Parse(killed.text) < int.Parse(stages[1]) && p_died != true)
            {
                obj_title.text = "Sad";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else if (p_died == true && int.Parse(killed.text) < int.Parse(stages[1]))
            {
                obj_title.text = "You Died";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else
            {
                obj_title.text = "Good Job";
                obj_sub.text = "Objective Complete";
                obj_button.text = "Next";
                p_succeed = true;
                Destroy(scene_);
            }
            obj_result.text = killed.text + " " + obj_result.text + " " + stages[1];
        }
        else if (stage_type == "chapter2_stage1")
        {
            if (int.Parse(killed.text) < int.Parse(stages[2]) && p_died != true)
            {
                obj_title.text = "Sad";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else if (p_died == true && int.Parse(killed.text) < int.Parse(stages[2]))
            {
                obj_title.text = "You Died";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else
            {
                obj_title.text = "Good Job";
                obj_sub.text = "Objective Complete";
                obj_button.text = "Next";
                p_succeed = true;
                Destroy(scene_);
            }
            obj_result.text = killed.text + " " + obj_result.text + " " + stages[2];
        }
        else if (stage_type == "chapter2_stage3")
        {
            if (int.Parse(killed.text) < int.Parse(stages[3]) && p_died != true)
            {
                obj_title.text = "Sad";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else if (p_died == true && int.Parse(killed.text) < int.Parse(stages[3]))
            {
                obj_title.text = "You Died";
                obj_sub.text = "Objective Failed";
                obj_button.text = "Try Again";
                p_failed = true;
            }
            else
            {
                obj_title.text = "Good Job";
                obj_sub.text = "Objective Complete";
                obj_button.text = "Next";
                p_succeed = true;
                Destroy(scene_);
            }
            obj_result.text = killed.text + " " + obj_result.text + " " + stages[3];
        }



    }

    public void scenereload(bool reload)
    {
        SceneManager.LoadScene("chapter1_stage2");
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Counter--;
            if (timestarts == true)
            {
                gameStart.SetActive(false);
                
            }
            
        }
    }
}
