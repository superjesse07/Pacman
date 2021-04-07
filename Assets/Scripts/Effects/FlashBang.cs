using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashBang : Effect
{
	public Image flash;
	private float alpha = 0;

	void Update ()
	{
		alpha -= Time.deltaTime * 2;
		flash.color = new Color(1,1,1,alpha);
	}

	protected override void Activate()
	{
		alpha = 1.5f;
	}

	protected override void DeActivate()
	{
		
	}
}
