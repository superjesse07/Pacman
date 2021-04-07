using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class EffectManager : MonoBehaviour {
    public List<Effect> effects = new List<Effect>();
    public float effectChance = 0.2f;
    public GameObject effectDisplay;
    public Transform effectPanel;
    private VerticalLayoutGroup layout;
    private int topPadding;
    public int panelHeight = 100;
    public float appear = 1;

    private void Start()
    {
        effects.AddRange(GetComponents<Effect>());
        layout = effectPanel.GetComponent<VerticalLayoutGroup>();
        topPadding = layout.padding.top;
    }


    private void Update()
    {
        if(appear < 1)
            appear += Time.deltaTime * 2;
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

        layout.padding.top = (int)Mathf.Lerp(topPadding - panelHeight, topPadding, appear);
        layout.SetLayoutVertical();
    }

    public void PickUp()
    {
        if (appear < 1) return;
        if (Random.Range(0, 1.0f) <= effectChance)
        {
            var available = effects.FindAll(x => !x.isActive);
            if (available.Count > 0)
            {
                var effect = available[Random.Range(0, available.Count)];
                effect.ActivateEffect();
                var display =  Instantiate(effectDisplay,Vector3.zero, Quaternion.identity,effectPanel);
                display.transform.SetSiblingIndex(0);
                display.GetComponent<EffectDisplay>().effect = effect;
                appear = 0;
            }
        }
    }
    
}
