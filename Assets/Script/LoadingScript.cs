using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadingScript : MonoBehaviour
{
    

    public Image UIobj;
    
    public float countTime ;

    public shoot shoottime;
    public float shotTimeSec;
    public bool roop  = false;


     void Start()
    {
       shoottime =  GameObject.Find("Player").GetComponent<shoot>();
       
    }


    
    void Update()
    {
        shotTimeSec = shoottime.timer;


        if (roop)
        {
            
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
        
        }
       
    }


    
    
}