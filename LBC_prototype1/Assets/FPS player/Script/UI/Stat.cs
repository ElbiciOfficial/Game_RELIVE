using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stat
{
    [SerializeField]
    private barscript bar;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float currentValue;

    public float CurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {      
            currentValue = Mathf.Clamp(value,0,MaxVal);
            bar.value = currentValue;
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            bar.MaxValue = value;
            maxVal = value;          
        }
    }
    public void Initialize()
    {
        MaxVal = maxVal;
        CurrentValue = currentValue;
    }
}
