using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour {

    public GameObject Floatingtextprefab;
    public int health = 50;
    public GameObject objective;
    objective_marker objc;
    //public Animator mob;
    //private int die_count = 2;

     void Start()
    {
        objective = GameObject.FindGameObjectWithTag("GameController");
        objc = objective.GetComponent<objective_marker>();
    }
    public void takedamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            die();
        }
        ShowFloatingText();
    }

    void ShowFloatingText()
    {
        GameObject go = Instantiate(Floatingtextprefab, transform.position, Quaternion.identity);
        go.GetComponent<TextMesh>().transform.rotation = Camera.main.transform.rotation;
        go.GetComponent<TextMesh>().text = health.ToString();
    }

    public void die()
    {
        //objective_marker ob = objective.GetComponent<objective_marker>();
        objc.addkill(1);
        Destroy(gameObject);
        //mob.SetBool("die", true);
        //StartCoroutine("die");
    }

    //public void Update()
    //{
    //    if(die_count == 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //IEnumerator loads()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1);


    //        die_count--;



    //    }
    //}
}
