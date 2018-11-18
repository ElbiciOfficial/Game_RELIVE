using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class barscript : MonoBehaviour {

    [SerializeField] private float fillamount;

    [SerializeField] private float lerpspeed;

    [SerializeField] private Image content;

    public float MaxValue { get; set; }

    public float value
    {
        set
        {
            fillamount = Map(value,0,MaxValue,0,1);
        }
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Handlebar();
	}
    private void Handlebar()
    {
        if(fillamount != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount,fillamount,Time.deltaTime * lerpspeed);
        }
        
    }
    private float Map(float value, float inMin,float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }

}
