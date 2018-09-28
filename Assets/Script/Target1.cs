using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target1 : MonoBehaviour
{
    //public float speed;
    //public float speed1;
    public float Random1;
    public float Random2;
    public float Random3;
    public float Random4;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(speed ,speed1, 0f);
        this.gameObject.transform.Translate(Random.Range(Random1,Random2), Random.Range(Random3,Random4), 0);
    }
}
