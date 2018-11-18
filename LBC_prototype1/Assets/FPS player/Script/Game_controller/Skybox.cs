﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour {

    public float rotatespeed = 1.2f;

	// Update is called once per frame
	void Update () {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotatespeed);
    }
}
