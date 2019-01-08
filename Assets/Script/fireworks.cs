using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fireworks : MonoBehaviour {
    public GameObject Fire;

     public AudioSource sound01;
    public AudioSource sound02;

 


   
    void Start () {

        //AudioSource[] audioSources = GetComponents<AudioSource>();
        // sound01 = audioSources[0];
        //  sound02 = audioSources[1];

        if (ScoreManager.score <= 80)
        {
         
            Fire.SetActive(false);
        
          sound01.PlayOneShot(sound01.clip);
        }


        if (ScoreManager.score >= 79)
        {
           
            Fire.SetActive(true);
             
               sound02.PlayOneShot(sound02.clip);


        }
    }
	
	
	void Update () {


      
        
	}
}
