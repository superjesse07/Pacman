using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverGonna : Effect {
    protected override void Activate()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        
    }

    protected override void DeActivate()
    {
        
    }
}
