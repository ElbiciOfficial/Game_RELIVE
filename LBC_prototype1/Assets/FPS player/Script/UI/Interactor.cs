using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactor : MonoBehaviour {

    
    public Camera camera;
    public float ray_Range;
    public GameObject interact;
    public KeyCode key;
    public GameObject inventorypanel;
    public Text text;
    int inum1;

    public string itemname;

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
                //Debug.Log("hello Energy");        
                if(ray_Hit.collider != null)
                {
                    text.text = "[E] " + ray_Hit.collider.tag;
                    inter();

                    if (Input.GetKeyDown(key))
                    {
                        if (ray_Hit.collider.tag == "Door")
                        {
                          
                                             
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
            //else
            //if (ray_Hit.collider.name == "Rifle_objct")
            //{
            //    //Debug.Log("hello RIFLE");
            //    inter();

            //    if (Input.GetKeyDown(key))
            //    {
            //        Destroy(ray_Hit.collider.gameObject);
            //        rifle1.SetActive(true);
            //        if (inum1 == 0)
            //        {
            //            Slot1.GetComponent<Image>().sprite = sprite2;
            //            inum1 = 1;
            //        }

            //    }
            //}
        }
    }
}
