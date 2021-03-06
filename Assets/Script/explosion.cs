﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {
    Rigidbody rb;
  
    public GameObject explode;//explodeにはunity上でprefabを関連付けます
    void Start()
    {
       
        rb = this.GetComponent<Rigidbody>(); //衝突時にオブジェクトを消す際に使用
    }
    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision) //衝突時の処理
    {
        //Destroy(this.gameObject);
        if (collision.gameObject.tag == "Bullet")
        //タグで限定（他のオブジェクトに衝突した場合は呼び出さない
        {
            rb.isKinematic = true; //位置を固定
            this.transform.localScale = Vector3.zero; //みえない大きさにする
           
            Instantiate(explode, this.transform.position, Quaternion.identity);
           
            //ぶつかった位置にexplodeというprefabを配置する



        }

        if (collision.gameObject.tag == "explosion")
        //タグで限定（他のオブジェクトに衝突した場合は呼び出さない
        {
            rb.isKinematic = true; //位置を固定
            this.transform.localScale = Vector3.zero; //みえない大きさにする
            Destroy(this.gameObject,0.5f);
            Instantiate(explode, this.transform.position, Quaternion.identity);
            //ぶつかった位置にexplodeというprefabを配置する

        }
    }
    

}