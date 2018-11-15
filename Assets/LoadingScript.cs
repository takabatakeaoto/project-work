using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadingScript : MonoBehaviour
{
    

    public Image UIobj;
    public bool roop;
    public float countTime = 5.0f;


     void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        

        if (roop)
        {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
        }
    }
}