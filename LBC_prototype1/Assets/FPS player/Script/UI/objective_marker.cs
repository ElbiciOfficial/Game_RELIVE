using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objective_marker : MonoBehaviour {


    public int Killed_enemy;
    public Text displaynum;
        
    public void addkill(int kill)
    {
        Killed_enemy += kill;
    }

    void Update()
    {
        displaynum.text = Killed_enemy.ToString();
        
    }
}
