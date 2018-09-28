using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         transform.position += new Vector3(speed, 0f, 0f);
        //this.gameObject.transform.Translate(Random.Range(0.05f, 0.1f), Random.Range(-0.1f, 0.1f), 0);
    }
}
