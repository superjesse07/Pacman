using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : MonoBehaviour
{
    public string name;
    public float duration = 5;
    [NonSerialized] public float timer;
    
    public bool isActive;

    public void ActivateEffect()
    {
        isActive = true;
        timer = duration;
        Activate();
    }

    public void DeActivateEffect()
    {
        isActive = false;
        DeActivate();
    }
    
    protected abstract void Activate();
    protected abstract void DeActivate();
}
