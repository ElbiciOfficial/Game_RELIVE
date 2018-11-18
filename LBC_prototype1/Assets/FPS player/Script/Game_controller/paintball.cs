using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintball : MonoBehaviour {
    public float speed = 10f;
    public int damage = 1;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        player_info player = other.GetComponent<player_info>();

        if(player != null)
        {
            player.Hurt(damage);
        }
        Destroy(this.gameObject);
    }

}
