using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverGonna : Effect {
    public override void Activate()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        isActive = true;
    }

    public override void DeActivate()
    {
        isActive = false;
    }
}
