using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpsideDown : Effect
{

    public Camera camera;
    public float rotation = 0;
    private float time;

    public override void Activate()
    {
        isActive = true;
    }

    private void Update()
    {
        if (isActive) time += Time.deltaTime * 2;
        else time -= Time.deltaTime * 2;
        time = Mathf.Clamp(time, 0, 1);
        rotation = Mathf.Lerp(0, 180, time);
        camera.transform.rotation = Quaternion.Euler(0,0,rotation);
    }

    public override void DeActivate()
    {
        isActive = false;
    }
}
