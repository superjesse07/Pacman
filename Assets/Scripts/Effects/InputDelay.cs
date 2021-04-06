using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDelay : Effect
{

	// test it
	
	public void Start() {

		Invoke("Activate", 2.0f);

	}
	

    public PlayerController player;
    public override void Activate()
    {
		player.Delayed = true;
        isActive = true;
		Invoke("DeActivate", 5.0f);
    }

    public override void DeActivate()
    {

		player.Delayed = false;
        isActive = false;
    }
}
