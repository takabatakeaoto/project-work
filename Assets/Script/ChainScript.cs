using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainScript : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            //this.transform.localScale = Vector3.zero; //みえない大きさにする

          //  if (Time.timeSinceLevelLoad > 10.0f)
          //  {

                Destroy(collision.gameObject,1f);
          //  }            
            
        }    
    }

  
}
