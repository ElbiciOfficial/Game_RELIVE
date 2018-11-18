using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_script : MonoBehaviour {

    public Button answer_;
    public GameObject gamemanager;
    // Use this for initialization
    void Start () {
        Button strt = answer_.GetComponent<Button>();
        strt.onClick.AddListener(ToggleAnswer);
    }
    public void ToggleAnswer()
    {
        if(gameObject.name == "yes_button")
        {
            question_script answer = gamemanager.GetComponent<question_script>();
            answer.addpoint(true);
        }else  if (gameObject.name == "no_button")
        {
            question_script answer = gamemanager.GetComponent<question_script>();
            answer.addpoint2(true);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
