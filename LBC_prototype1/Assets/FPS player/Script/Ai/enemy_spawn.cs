using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour {

    public GameObject ball;
    public GameObject[] c1stage4 = new GameObject[2];
    public GameObject ball2;
    public GameObject[] c2stage4 = new GameObject[2];
    public GameObject[] c3stage2 = new GameObject[2];
    public GameObject[] c3stage4 = new GameObject[3];

    public float spawnTime = 3f;
   
    public GameObject spawn;

    public bool start = false;
    public GameObject scene_;
    public string stage_type;

    // Use this for initialization
    void Start()
    {
       
        InvokeRepeating("SpawnBall", spawnTime, spawnTime);
        scene_ = GameObject.Find("scene name");
        scene_name s_name = scene_.GetComponent<scene_name>();
        stage_type = s_name.Name_s;
     
    }

    void SpawnBall()
    {
        if(start == true)
        {
            if(stage_type == "chapter1_stage1")
            {
                var newspawn = spawn.transform.position;
                var newBall = GameObject.Instantiate(ball);
                newBall.transform.position = newspawn;
            }
            else if(stage_type == "chapter1_stage3")
            {
                var newspawn = spawn.transform.position;
                var newBall = GameObject.Instantiate(c1stage4[Random.Range(0,2)]);
                newBall.transform.position = newspawn;
            }
            else if (stage_type == "chapter2_stage1")
            {
                var newspawn = spawn.transform.position;
                var newBall = GameObject.Instantiate(ball2);
                newBall.transform.position = newspawn;
            }
            else if (stage_type == "chapter2_stage3")
            {
                var newspawn = spawn.transform.position;
                var newBall = GameObject.Instantiate(c2stage4[Random.Range(0, 2)]);
                newBall.transform.position = newspawn;
            }
            else if (stage_type == "chapter3_stage1")
            {
                var newspawn = spawn.transform.position;
                var newBall = GameObject.Instantiate(c3stage2[Random.Range(0, 2)]);
                newBall.transform.position = newspawn;
            }
            else if (stage_type == "chapter3_stage3")
            {
                var newspawn = spawn.transform.position;
                var newBall = GameObject.Instantiate(c3stage4[Random.Range(0, 3)]);
                newBall.transform.position = newspawn;
            }


        }
    
    }

    public void startspawn(bool enemy)
    {
        start = enemy;
    }


}
