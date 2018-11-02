using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision) //衝突時の処理
    {
        //Destroy(this.gameObject);
        if (collision.gameObject.CompareTag("Bullet"))
        {
           
            Destroy(collision.gameObject);
        }
    }
}
