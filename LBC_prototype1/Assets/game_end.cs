using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_end : MonoBehaviour {

    public Animator loadscreen;
	// Use this for initialization
	void Start () {

        loadscreen.SetBool("open", true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
