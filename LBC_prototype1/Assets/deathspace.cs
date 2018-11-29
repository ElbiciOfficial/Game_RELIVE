using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathspace : MonoBehaviour {

    public GameObject player;
    public int damage = 100;
    private player_info play;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        play = player.GetComponent<player_info>();
    }

    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            play.Hurt(damage);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
