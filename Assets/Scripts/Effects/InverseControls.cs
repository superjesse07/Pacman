using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverseControls : Effect
{

	public PlayerController player;

    protected override void Activate()
    {
		player.Inverted = true;
		
    }

    protected override void DeActivate()
    {

		player.Inverted = false;
		
    }
}
