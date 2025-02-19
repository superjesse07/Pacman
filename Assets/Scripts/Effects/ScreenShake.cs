﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScreenShake : Effect
{
    private float shakeDuration;
    public float shakeStrength;
    private const float screenShakeFalloff = 0.4f;
    public Transform camera;
    private Vector3 cameraPos;

    private void Start()
    {
        cameraPos = camera.position;
    }


    protected override void Activate()
    {
    }

    private void Update()
    {
        if (shakeDuration > 0 )
        {
            shakeDuration -= Time.deltaTime;
            Vector3 offset = Random.insideUnitCircle * (shakeStrength * (Math.Min(shakeDuration, screenShakeFalloff) / screenShakeFalloff));
            camera.position = cameraPos + offset;
        }
    }

    protected override void DeActivate()
    {
    }

    public void Shake()
    {
        if (isActive)
        {
            shakeDuration = 0.1f;
        }
    }
}
