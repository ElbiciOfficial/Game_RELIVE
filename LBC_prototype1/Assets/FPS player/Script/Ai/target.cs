using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour {

    public GameObject Floatingtextprefab;
    public int health = 50;
    public GameObject objective;
    objective_marker objc;


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
    }
}
