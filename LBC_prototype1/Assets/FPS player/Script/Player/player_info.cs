using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_info : MonoBehaviour {

    public float player_health;
    public float player_energy;
    public GameObject player;
    public gunscript script1;
    public GameObject weapon1;

    public gunscript script2;
    public GameObject weapon2;

    [SerializeField]
    private Stat Health;

    [SerializeField]
    private Stat Energy;

    private void Awake()
    {
        Health.Initialize();
        Energy.Initialize();
    }

     void Update()
    {
        
        if(weapon1.activeInHierarchy == true)
        {
            player_energy = script1.ammo ;
            Energy.CurrentValue = player_energy;
        }

        //if (weapon2.activeInHierarchy == true)
        //{
        //    player_energy = script2.ammo;
        //    Energy.CurrentValue = player_energy;
        //}

        Health.CurrentValue = player_health;
        if(player_health == 0)
        {

        }
    }

    public void Hurt(int damage)
    {
        player_health -= damage;
        Debug.Log("Health: " + player_health);
      
    }


}
