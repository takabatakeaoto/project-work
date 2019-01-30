using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class DestroyTarget : MonoBehaviour {

   
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // this.transform.localScale = Vector3.zero;
            // Destroy(collision.gameObject);
            SceneManager.LoadScene("gameclear");
        }
    }

}
