using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpsideDown : Effect
{

    public Camera camera;
    public override void Activate()
    {
        isActive = true;
        camera.transform.Rotate(0,0,180);
    }

    public override void DeActivate()
    {
        camera.transform.Rotate(0,0,180);
        isActive = false;
    }
}
