using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_limiter : MonoBehaviour {

    private GameObject[] numofitems;
  
    public Item_spawn spawn0;
    public Item_spawn spawn1;
    public Item_spawn spawn2;
    public Item_spawn spawn3;
    public Item_spawn spawn4;
    public Item_spawn spawn5;
    public Item_spawn spawn6;
    public Item_spawn spawn7;
    public Item_spawn spawn8;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        numofitems = GameObject.FindGameObjectsWithTag("Energy");
        //Debug.Log("item spawn: " + numofitems.Length);

        if (numofitems.Length >= 4)
        {
            Item_spawn enspawn1 = spawn0.GetComponent<Item_spawn>();
            Item_spawn enspawn2 = spawn1.GetComponent<Item_spawn>();
            Item_spawn enspawn3 = spawn2.GetComponent<Item_spawn>();
            Item_spawn enspawn4 = spawn3.GetComponent<Item_spawn>();
            Item_spawn enspawn5 = spawn4.GetComponent<Item_spawn>();
            Item_spawn enspawn6 = spawn5.GetComponent<Item_spawn>();
            Item_spawn enspawn7 = spawn6.GetComponent<Item_spawn>();
            Item_spawn enspawn8 = spawn7.GetComponent<Item_spawn>();
            Item_spawn enspawn9 = spawn8.GetComponent<Item_spawn>();

            enspawn1.startspawn(false);
            enspawn2.startspawn(false);
            enspawn3.startspawn(false);
            enspawn4.startspawn(false);
            enspawn5.startspawn(false);
            enspawn6.startspawn(false);
            enspawn7.startspawn(false);
            enspawn8.startspawn(false);
            enspawn9.startspawn(false);
          
        }
        else if(numofitems.Length < 4)
        {

            Item_spawn enspawn1 = spawn0.GetComponent<Item_spawn>();
            Item_spawn enspawn2 = spawn1.GetComponent<Item_spawn>();
            Item_spawn enspawn3 = spawn2.GetComponent<Item_spawn>();
            Item_spawn enspawn4 = spawn3.GetComponent<Item_spawn>();
            Item_spawn enspawn5 = spawn4.GetComponent<Item_spawn>();
            Item_spawn enspawn6 = spawn5.GetComponent<Item_spawn>();
            Item_spawn enspawn7 = spawn6.GetComponent<Item_spawn>();
            Item_spawn enspawn8 = spawn7.GetComponent<Item_spawn>();
            Item_spawn enspawn9 = spawn8.GetComponent<Item_spawn>();

            enspawn1.startspawn(true);
            enspawn2.startspawn(true);
            enspawn3.startspawn(true);
            enspawn4.startspawn(true);
            enspawn5.startspawn(true);
            enspawn6.startspawn(true);
            enspawn7.startspawn(true);
            enspawn8.startspawn(true);
            enspawn9.startspawn(true);
        }
    }

//    public void itemlimit(float itemnum)
//    {
//        numberofitems += itemnum;
//    }
//    public void itemlimit2(float itemnum)
//    {
//        numberofitems -= itemnum;
//    }
}
