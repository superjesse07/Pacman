using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : Effect
{

	// test it
	
	/*
	public void Start() {

		Invoke("Activate", 2.0f);

	}
	*/

    public SpriteRenderer player;
    public override void Activate()
    {
		player.enabled = false;
        isActive = true;
    }

    public override void DeActivate()
    {

		player.enabled = true;
        isActive = false;
    }
}
