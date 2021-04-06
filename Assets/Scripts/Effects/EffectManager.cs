using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EffectManager : MonoBehaviour {
    public List<Effect> effects = new List<Effect>();
    public float effectChance = 0.2f;
    
    private void Start()
    {
        effects.AddRange(GetComponents<Effect>());
    }


    private void Update()
    {
        foreach(Effect e in effects)
        {
            if (e.isActive)
            {
                e.timer -= Time.deltaTime;
                if (e.timer < 0)
                {
                    e.DeActivateEffect();
                }
            }
        }
    }

    public void PickUp()
    {
        if (Random.Range(0, 1.0f) <= effectChance)
        {
            var available = effects.FindAll(x => !x.isActive);
            if (available.Count > 0)
            {
                var effect = available[Random.Range(0, available.Count)];
                effect.ActivateEffect();
            }
        }
    }
    
}
