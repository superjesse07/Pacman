using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : MonoBehaviour
{
    [NonSerialized]public string name;
    [NonSerialized]public string description;
    [NonSerialized]public float duration;
    [NonSerialized] public float timer;
    
    public bool isActive;
    public abstract void Activate();
    public abstract void DeActivate();
}
