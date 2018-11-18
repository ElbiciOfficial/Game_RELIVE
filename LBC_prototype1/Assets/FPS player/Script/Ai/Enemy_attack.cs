using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_attack : MonoBehaviour {

   
    //public GameObject paintballprefab;
    //private GameObject _paintball;
    //private float nexttimetofire = 2f;
    //public float firerate = 20f;
    float timer;
    public float timeBetweenAttacks = 0.5f;
    bool playerInRange; 
    public GameObject player;
    public int damage = 10;
    public player_info play;

     void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        play = player.GetComponent<player_info>();
    }

    void Update () {
        timer += Time.deltaTime;

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if (timer >= timeBetweenAttacks && playerInRange)
        {
            // ... attack.
            Attack();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is in range.
            playerInRange = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is no longer in range.
            playerInRange = false;
        }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    //if (other.GetComponent<player_info>() && Time.time >= nexttimetofire && _paintball == null)
    //    //{
    //    //    nexttimetofire = Time.time + 5f / firerate;
    //    //    _paintball = Instantiate(paintballprefab) as GameObject;
    //    //    _paintball.transform.position = transform.TransformPoint(Vector3.forward * 1.1f);
    //    //    _paintball.transform.rotation = transform.rotation;

    //    //}
    //    //if (other.GetComponent<player_info>())
    //    //{
    //    //    if (_paintball == null)
    //    //    {
    //    //        _paintball = Instantiate(paintballprefab) as GameObject;
    //    //        _paintball.transform.position = transform.TransformPoint(Vector3.forward * 1.1f);
    //    //        _paintball.transform.rotation = transform.rotation;
    //    //    }
    //    //}
    //}

    public void Attack()
    {
     
        // Reset the timer.
        timer = 0f;      
        play.Hurt(damage);
    
    } 
}
