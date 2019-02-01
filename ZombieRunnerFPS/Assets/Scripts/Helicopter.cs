﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    public AudioClip callSound;
    private bool called = false;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("CallHeli") && !called) {
            // Call the helicopter
            called = true;
            // Play sound
            audioSource.clip = callSound;
            print ("Helicopter called");
            audioSource.Play();
        }
    }
}
