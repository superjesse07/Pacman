using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigClyde : Effect
{
	private float clydeScale = 1;
	public Transform clyde;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isActive)
			clydeScale += Time.deltaTime;
		else
			clydeScale -= Time.deltaTime;
		clydeScale = Mathf.Clamp(clydeScale, 1, 5);
		clyde.localScale = Vector3.one * clydeScale;
	}

	protected override void Activate()
	{
		
	}

	protected override void DeActivate()
	{
		
	}
}
