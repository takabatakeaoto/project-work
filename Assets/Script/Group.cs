using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour {
    public GameObject[] groups;
    private int number;

    // Use this for initialization
    void Start()
    {
        number = Random.Range(0, groups.Length);
        Instantiate(groups[number], transform.position, transform.rotation);
    }


  // Update is called once per frame
  void Update () {
		
	}
}
