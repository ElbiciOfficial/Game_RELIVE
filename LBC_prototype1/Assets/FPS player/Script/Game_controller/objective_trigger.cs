﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective_trigger : MonoBehaviour {

    public GameObject objectUI;
  
    //public GameObject gamemanager;
    ////public Camera playercam;


    void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "objective_trigger")
        {

            chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();

            //objectUI.SetActive(true); 
            chap1.activateobj(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "dialogue_trigger")
        {
            chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();

            //objectUI.SetActive(true);
            chap1.activatediag(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "objective_trigger 2")
        {
            chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();

            //objectUI.SetActive(true);
            chap1.activateobj2(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "dialogue_trigger 2")
        {
            chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();

            //objectUI.SetActive(true);
            chap1.activatediag2(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "dialogue_trigger 3")
        {
            chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();

            //objectUI.SetActive(true);
            chap1.activatediag3(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "dialogue_trigger chapt2")
        {
            Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();

            //objectUI.SetActive(true);
            chap2.activatediag(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "dialogue_trigger chapt2 2")
        {
            Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();

            //objectUI.SetActive(true);
            chap2.activatediag2(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "dialogue_trigger chapt2 3")
        {
            Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();

            //objectUI.SetActive(true);
            chap2.activatediag3(true);
            Destroy(gameObject);
        }
        else if (gameObject.name == "dialogue_trigger chapt2 3.1")
        {
            Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();

            //objectUI.SetActive(true);
            chap2.activatediag4(true);
            Destroy(gameObject);
        }

    }

}
