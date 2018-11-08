﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fireworks : MonoBehaviour {
    public GameObject Fire;
    public AudioClip sound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(ScoreManager.score < 80)
        {
            Fire.SetActive(false);
        }


        if (ScoreManager.score >= 80)
        {
        AudioSource.PlayClipAtPoint(sound, transform.position);

         Fire.SetActive(true);
        }
	}
}
