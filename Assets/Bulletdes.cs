using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.tag  == "explosion")
        {
            Destroy(collision.gameObject);
            this.transform.localScale = Vector3.zero;
        }
    }
}
