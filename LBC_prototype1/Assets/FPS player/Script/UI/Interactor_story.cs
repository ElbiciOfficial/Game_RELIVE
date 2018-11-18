﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Interactor_story : MonoBehaviour {

    public Camera camera;
    public float ray_Range;
    public GameObject interact;
    public KeyCode key;
    public GameObject inventorypanel;
    public Text text;
    int inum1;
    public Animator door1;
    public Animator door2;
    public Animator door3;
    public Animator door4;
    public Animator door5;
    private bool isopen1 = false;
    private bool isopen2 = false;
    private bool isopen3 = false;
    private bool isopen4 = false;
    private bool isopen5 = false;

    private bool item1_done = false;
    private bool item2_done = false;

    private bool c2item1_done = false;
    private bool c2item2_done = false;

    public string itemname;

    public GameObject objectUI;
    public string leveltoload;
    private int portal_count = 3;
    public Animator loadscene;

    public GameObject _scenename;

    void inter()
    {

        interact.SetActive(true);
    }

    void Update()
    {
        interact.SetActive(false);
        Ray ray_Cast = camera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit ray_Hit;

        if (Physics.Raycast(ray_Cast, out ray_Hit, ray_Range))
        {

            if (ray_Hit.collider.tag != "Enemy" && ray_Hit.collider.tag != "static_obj" && ray_Hit.collider.tag != "Enemy_Attack" && ray_Hit.collider.tag != "Player_Attack" && ray_Hit.collider.tag != "Player")
            {                  
                if (ray_Hit.collider != null)
                {
                    text.text = "[E] " + ray_Hit.collider.tag;
                    inter();

                    if (Input.GetKeyDown(key))
                    {
                        if (ray_Hit.collider.tag == "Door")
                        {

                            if (ray_Hit.collider.name == "Door1.1")
                            {
                                isopen1 = !isopen1;
                                door1.SetBool("open", isopen1);

                            }
                            else if (ray_Hit.collider.name == "Door1.2")
                            {
                                isopen2 = !isopen2;
                                door2.SetBool("open", isopen2);
                            }
                            else if(ray_Hit.collider.name == "Door2")
                            {
                                isopen3 = !isopen3;
                                door3.SetBool("open", isopen3);

                            }
                            else if (ray_Hit.collider.name == "Door3")
                            {
                                isopen4 = !isopen4;
                                door4.SetBool("open", isopen4);
                            }
                            else if (ray_Hit.collider.name == "Door1 chapt2")
                            {
                                isopen5 = !isopen5;
                                door5.SetBool("open_door", isopen5);
                            }

                        }
                        else if (ray_Hit.collider.tag == "Urn")
                        {
                   
                                chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();
                            chap1.activateurn(true);                           
                        }
                        else if (ray_Hit.collider.tag == "Sketch")
                        {

                            Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();
                            chap2.activatesketch(true);
                        }
                        else if (ray_Hit.collider.tag == "Empty Picture Frame")
                        {
                            if(item1_done == true)
                            {
                                chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();
                                chap1.piece1done(true);
                            }
                            else if (item2_done == true)
                            {
                                chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();
                                chap1.piece2done(true);
                            }
                            else
                            {
                                chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();
                                chap1.activatepic(true);
                            }
                        
                        }
                        else if (ray_Hit.collider.tag == "Picture piece")
                        {
                            if (ray_Hit.collider.name == "picture - 1")
                            {
                                chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();
                                chap1.picpiece1(true);
                                item1_done = true;
                                Destroy(ray_Hit.collider.gameObject);
                            }
                            else if (ray_Hit.collider.name == "picture - 2")
                            {
                                chapter1_path chap1 = objectUI.GetComponent<chapter1_path>();
                                chap1.picpiece2(true);
                                item2_done = true;
                                Destroy(ray_Hit.collider.gameObject);
                            }
                        }
                        else if (ray_Hit.collider.tag == "Robot piece")
                        {
                            if (ray_Hit.collider.name == "robot1")
                            {
                                Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();                             
                                chap2.robpiece1(true);
                                c2item1_done = true;
                                Destroy(ray_Hit.collider.gameObject);
                            }
                            else if (ray_Hit.collider.name == "robot2")
                            {
                                Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();
                                chap2.robpiece2(true);
                                c2item2_done = true;
                                Destroy(ray_Hit.collider.gameObject);
                            }
                        }
                        else if (ray_Hit.collider.tag == "Empty Stand")
                        {
                            if (c2item1_done == true)
                            {
                                Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();
                                chap2.piece1done(true);
                            }
                            else if (c2item2_done == true)
                            {
                                Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();
                                chap2.piece2done(true);
                            }
                            else
                            {
                                Chapter2_path chap2 = objectUI.GetComponent<Chapter2_path>();
                                chap2.activaterob(true);
                            }

                        }
                        else if (ray_Hit.collider.tag == "Portal")
                        {
                            loadscene.SetBool("load", true);
                            loadscene.SetBool("open", false);
                            StartCoroutine("loadscreen");
                            DontDestroyOnLoad(_scenename);
                        }
                        else
                        {
                            Inventory item = inventorypanel.GetComponent<Inventory>();
                            itemname = ray_Hit.collider.tag;
                            item.Additem(itemname);
                            Destroy(ray_Hit.collider.gameObject);
                        }

                    }
                }

            }

            if (portal_count == 0)
            {
                SceneManager.LoadScene(leveltoload);
            }        
          
        }
    }
    IEnumerator loadscreen()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            portal_count--;



        }
    }
}


