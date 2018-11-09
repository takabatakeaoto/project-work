using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fireworks : MonoBehaviour {
    public GameObject Fire;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(ScoreManager.score < 50)
        {
            Fire.SetActive(false);

            Fire.GetComponent<AudioSource>().Play();
        }


        if (ScoreManager.score >= 50)
        {
            Fire.SetActive(true);
 

        
        }
	}
}
