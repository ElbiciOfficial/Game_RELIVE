using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadunit : MonoBehaviour {

    public string scene_name;
    public string scene_stage;

    public int numr;
    public int numw;

    public  void Setscene(string scene) {

        scene_name = scene;
    }
    public void Setstage(string stage)
    {
        scene_stage = stage;

    }
    public void Setright(int r)
    {
        numr = r;

    }
    public void Setwrong(int w)
    {
        numw = w;

    }
}
