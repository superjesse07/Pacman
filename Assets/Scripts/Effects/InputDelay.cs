using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDelay : Effect
{

	// test it
	
	public void Start() {
	}
	

    public PlayerController player;

    protected override void Activate()
    {
		player.Delayed = true;
    }

    protected override void DeActivate()
    {

		player.Delayed = false;
    }
}
