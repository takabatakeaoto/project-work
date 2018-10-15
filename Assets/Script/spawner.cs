﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//指定したゲームオブジェクトを無限スポーンさせるスクリプト
public class spawner : MonoBehaviour
{
    
    //発生するオブジェクトをInspectorから指定する用
    public GameObject spawnObject;
    //発生間隔用
    public float interval;


    void Start()
    {

  

        //コルーチンの開始
        StartCoroutine("Spawn");
    }


   

    IEnumerator Spawn()
    {
        //無限ループの開始
        while (true)
        {
            //自分をつけたオブジェクトの位置に、発生するオブジェクトをインスタンス化して生成する
            GameObject obj = Instantiate(spawnObject, transform.position, Quaternion.identity);
            obj.transform.Rotate(new Vector3(0, 90, 0));
            yield return new WaitForSeconds(interval);
        }
    }

}