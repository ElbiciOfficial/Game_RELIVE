using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal_script : MonoBehaviour {

    public ParticleSystem portal_1;

     void start()
    {
        Cursor.lockState = CursorLockMode.None;
        portal_1.Play();
    }
    //public GameObject ui;
    //public string leveltoload;
    //public KeyCode enter;

    // void OnTriggerStay(Collider other)
    //{
    //    if(other.gameObject.tag == "Player")
    //    {
    //        ui.SetActive(true);
    //        if (Input.GetKeyDown(enter))
    //        {

    //        }
    //    }

    //}

    // void OnTriggerExit()
    //{

    //    ui.SetActive(false);
    //}
}
