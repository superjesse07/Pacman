using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : Effect
{
	public PlayerController player;

    protected override void Activate()
    {
		player.speed *= 0.8f;
		
    }

    protected override void DeActivate()
    {

		player.speed /= 0.8f;
    }
}
