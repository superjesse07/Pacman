using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : Effect
{

	public SpriteRenderer player;

    protected override void Activate()
    {
		player.enabled = false;
    }

    protected override void DeActivate()
    {

		player.enabled = true;
    }
}
