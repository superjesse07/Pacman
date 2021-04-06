using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Effect
{
	

    public PlayerController player;

    protected override void Activate()
    {
		player.speed *= 15.0f;
		
    }

    protected override void DeActivate()
    {

		player.speed /= 15.0f;
		
    }
}
