using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : Effect
{

	// test it
	/*
	public void Start() {

		Invoke("Activate", 2.0f);

	}
	*/

    public PlayerController player;
    public override void Activate()
    {
		player.speed *= 0.8f;
        isActive = true;
    }

    public override void DeActivate()
    {

		player.speed /= 0.8f;
        isActive = false;
    }
}
