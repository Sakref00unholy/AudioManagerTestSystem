﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicTrigger : MonoBehaviour
{
    public AudioClip newTrack;

    private AudioManager theAM;
    void Start()
    {
        theAM = FindObjectOfType<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (newTrack != null)
                theAM.ChangeBGM(newTrack);
            
            
        }
    }
}
