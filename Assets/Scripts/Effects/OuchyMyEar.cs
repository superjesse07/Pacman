﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class OuchyMyEar : Effect{
    public List<AudioClip> clips = new List<AudioClip>();
    private List<AudioSource > sources = new List<AudioSource>();
    private void Start()
    {
        foreach (var clip in clips)
        {
            var source = gameObject.AddComponent<AudioSource>();
            source.clip = clip;
            source.playOnAwake = false;
            source.volume = 0.2f;
            sources.Add(source);
        }
    }

    protected override void Activate()
    {
        
    }

    protected override void DeActivate()
    {
        
    }

    public void Play()
    {
        if (isActive)
        {
            sources[Random.Range(0,sources.Count)].Play();
        }
    }
}
