using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Effect
{
	

    public PlayerController player;
    public float speed = 30;

    protected override void Activate()
    {
		player.speed *= speed;
		
    }

    protected override void DeActivate()
    {

		player.speed /= speed;
		
    }
}
