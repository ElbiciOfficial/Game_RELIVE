using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public Image[] imagelist = new Image[6];

    public string[] itemlist = new string[6];
    public string weapon;

    public int[] selectedslot = new int[6];

    public Text[] hotkeytxt = new Text[6];
    public Image weaponslot;

    public Sprite[] spritelist = new Sprite[10];

    public string newitem;
    public GameObject player;

    public GameObject weapon1;

    public GameObject inventorypanel;
    public GameObject inventoryicon;
    public GameObject menupanel;
    public KeyCode inventory;
    public KeyCode menu;

    
    public KeyCode slot1;
    public KeyCode slot2;
    public KeyCode slot3;
    public KeyCode slot4;
    public KeyCode slot5;
    public KeyCode slot6;
    private int selected = 1;

    public KeyCode usebutton;

    private bool isshow = false;
    private bool menushow = false;
    private bool Iicon = true;

    private Color32 c;
    private Color32 w;
    private Color32 t;

    private float energy;
    public Text action;
    public GameObject acpanel;

    public GameObject bullet;

    void Start()
    {
         c = new Color32(236, 225, 150, 255);
         w = new Color32(255, 255, 255, 255);
         t = new Color32(115, 105, 105, 255);
        for (int i = 0; i < selectedslot.Length; i++)
        {
            selectedslot[i] = 0;
        }
    }

    public void Additem(string item)
    {
        newitem = item;
     
        for (int i = 0; i < itemlist.Length; i++)
        {

            Debug.Log(itemlist[i]);
            if (itemlist[i] == "")
            {
                itemlist[i] = newitem;
                Debug.Log(itemlist[i]);
                if(itemlist[i] == "Energy")
                {
                    imagelist[i].GetComponent<Image>().sprite = spritelist[0];
                }
                else if (itemlist[i] == "Energy X")
                {
                    imagelist[i].GetComponent<Image>().sprite = spritelist[0];
                }
                else if(itemlist[i] == "Weapon")
                {
                    imagelist[i].GetComponent<Image>().sprite = spritelist[1];
                }               
                break;
            }
        }
    }

  

    void showinventory()
    {
        inventorypanel.SetActive(isshow);
        inventoryicon.SetActive(Iicon);
    }

    void showmenu()
    {
        menupanel.SetActive(menushow);
    }

    // Update is called once per frame
    void Update ()
    {

        if (Time.time >= 6)
        {
            gunscript gun = weapon1.GetComponent<gunscript>();

            if (Input.GetKeyDown(inventory))
            {
                isshow = !isshow;
                Iicon = !Iicon;
                showinventory();
            }

            if (Input.GetKeyDown(menu))
            {
                menushow = !menushow;
                showmenu();
            }

            // INVENTORY HOTKEYS
            if (Input.GetKeyDown(slot1))
            {
                if (itemlist[0] != "")
                {

                    Debug.Log("SLOT1");
                    for (int i = 0; i < selectedslot.Length; i++)
                    {
                        if (i == 0)
                        {
                            selectedslot[i] = 1;
                            imagelist[i].GetComponent<Image>().color = c;
                            hotkeytxt[i].GetComponent<Text>().color = c;
                        }
                        else
                        {
                            selectedslot[i] = 0;
                            imagelist[i].GetComponent<Image>().color = w;
                            hotkeytxt[i].GetComponent<Text>().color = t;
                        }
                    }

                }

            }
            else if (Input.GetKeyDown(slot2))
            {
                if (itemlist[1] != "")
                {

                    Debug.Log("SLOT2");
                    for (int i = 0; i < selectedslot.Length; i++)
                    {
                        if (i == 1)
                        {
                            selectedslot[i] = 1;
                            imagelist[i].GetComponent<Image>().color = c;
                            hotkeytxt[i].GetComponent<Text>().color = c;
                        }
                        else
                        {
                            selectedslot[i] = 0;
                            imagelist[i].GetComponent<Image>().color = w;
                            hotkeytxt[i].GetComponent<Text>().color = t;
                        }
                    }

                }

            }
            else if (Input.GetKeyDown(slot3))
            {
                if (itemlist[2] != "")
                {

                    Debug.Log("SLOT3");
                    for (int i = 0; i < selectedslot.Length; i++)
                    {
                        if (i == 2)
                        {
                            selectedslot[i] = 1;
                            imagelist[i].GetComponent<Image>().color = c;
                            hotkeytxt[i].GetComponent<Text>().color = c;
                        }
                        else
                        {
                            selectedslot[i] = 0;
                            imagelist[i].GetComponent<Image>().color = w;
                            hotkeytxt[i].GetComponent<Text>().color = t;
                        }
                    }

                }

            }
            else if (Input.GetKeyDown(slot4))
            {
                if (itemlist[3] != "")
                {

                    Debug.Log("SLOT4");
                    for (int i = 0; i < selectedslot.Length; i++)
                    {
                        if (i == 3)
                        {
                            selectedslot[i] = 1;
                            imagelist[i].GetComponent<Image>().color = c;
                            hotkeytxt[i].GetComponent<Text>().color = c;
                        }
                        else
                        {
                            selectedslot[i] = 0;
                            imagelist[i].GetComponent<Image>().color = w;
                            hotkeytxt[i].GetComponent<Text>().color = t;
                        }
                    }

                }

            }
            else if (Input.GetKeyDown(slot5))
            {
                if (itemlist[4] != "")
                {

                    Debug.Log("SLOT5");
                    for (int i = 0; i < selectedslot.Length; i++)
                    {
                        if (i == 4)
                        {
                            selectedslot[i] = 1;
                            imagelist[i].GetComponent<Image>().color = c;
                            hotkeytxt[i].GetComponent<Text>().color = c;
                        }
                        else
                        {
                            selectedslot[i] = 0;
                            imagelist[i].GetComponent<Image>().color = w;
                            hotkeytxt[i].GetComponent<Text>().color = t;
                        }
                    }

                }

            }
            else if (Input.GetKeyDown(slot6))
            {
                if (itemlist[5] != "")
                {

                    Debug.Log("SLOT6");
                    for (int i = 0; i < selectedslot.Length; i++)
                    {
                        if (i == 5)
                        {
                            selectedslot[i] = 1;
                            imagelist[i].GetComponent<Image>().color = c;
                            hotkeytxt[i].GetComponent<Text>().color = c;
                        }
                        else
                        {
                            selectedslot[i] = 0;
                            imagelist[i].GetComponent<Image>().color = w;
                            hotkeytxt[i].GetComponent<Text>().color = t;
                        }
                    }

                }

            }

            // ITEM USE BUTTON
            if (Input.GetKeyDown(usebutton))
            {
                for (int i = 0; i < selectedslot.Length; i++)
                {
                    if (selectedslot[i] == 1)
                    {
                        if (itemlist[i] == "Energy")
                        {
                            if (weapon != "")
                            {

                                if (gun.ammo <= 50)
                                {
                                    energy = 100;
                                    gun.Energy(energy);
                                    itemlist[i] = "";
                                    imagelist[i].GetComponent<Image>().sprite = null;
                                    imagelist[i].GetComponent<Image>().color = w;
                                    hotkeytxt[i].GetComponent<Text>().color = t;
                                    selectedslot[i] = 0;
                                    player_bullet bull = bullet.GetComponent<player_bullet>();
                                    bull.damage = 8;
                                }
                                else if (gun.ammo >= 51)
                                {
                                    acpanel.SetActive(true);
                                    action.text = "You still have 60% of weapon energy";
                                    StartCoroutine(LateCall());

                                }
                            }
                            else
                            {
                                acpanel.SetActive(true);
                                action.text = "No Weapon";
                                StartCoroutine(LateCall());
                            }

                        }
                        else if (itemlist[i] == "Energy X")
                        {
                            if (weapon != "")
                            {

                                if (gun.ammo <= 50)
                                {
                                    energy = 70;
                                    gun.Energy(energy);
                                    itemlist[i] = "";
                                    imagelist[i].GetComponent<Image>().sprite = null;
                                    imagelist[i].GetComponent<Image>().color = w;
                                    hotkeytxt[i].GetComponent<Text>().color = t;
                                    selectedslot[i] = 0;
                                    player_bullet bull = bullet.GetComponent<player_bullet>();
                                    bull.damage = 17;

                                }
                                else if (gun.ammo >= 51)
                                {
                                    acpanel.SetActive(true);
                                    action.text = "You still have 60% of weapon energy";
                                    StartCoroutine(LateCall());

                                }
                            }
                            else
                            {
                                acpanel.SetActive(true);
                                action.text = "No Weapon";
                                StartCoroutine(LateCall());
                            }

                        }
                        else if (itemlist[i] == "Weapon")
                        {
                            Playermove pla = player.GetComponent<Playermove>();
                            pla.arm(true);
                            weapon1.SetActive(true);
                            //gun.firee.SetBool("hold", true);
                            weapon = itemlist[i];
                            itemlist[i] = "";
                            imagelist[i].GetComponent<Image>().sprite = null;
                            imagelist[i].GetComponent<Image>().color = w;
                            hotkeytxt[i].GetComponent<Text>().color = t;
                            selectedslot[i] = 0;
                            weaponslot.GetComponent<Image>().sprite = spritelist[1];
                        }

                        //gun.firee.SetBool("hold", false);
                    }
                }
            }
        }
            
       
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(5);

        acpanel.SetActive(false);
        //Do Function here...
    }
}
