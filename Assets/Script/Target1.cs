﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target1 : MonoBehaviour
{

    public int score;  // これが敵を倒すと得られる点数になる
    private ScoreManager sm;

    //public float speed;
    //public float speed1;
    public float Random1;
    public float Random2;
    public float Random3;
    public float Random4;
    public int RemainingTime;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("TimeBomb");
        // 「ScoreManagerオブジェクト」に付いている「ScoreManagerスクリプト」の情報を取得して「sm」の箱に入れる。
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(speed ,speed1, 0f);
        this.gameObject.transform.Translate(Random.Range(Random1,Random2), Random.Range(Random3,Random4), 0);
    }

    void OnCollisionEnter(Collision collision) //衝突時の処理
    {
        //Destroy(this.gameObject);
        if (collision.gameObject.tag == "Bullet")
        //タグで限定（他のオブジェクトに衝突した場合は呼び出さない
        {

            this.transform.localScale = Vector3.zero; //みえない大きさにする
            sm.AddScore(score);
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            //Debug.Log("Bullet Tag");
            Destroy(collision.gameObject);
        }
    }
    IEnumerator TimeBomb()
    {
        yield return new WaitForSeconds(RemainingTime);
        Destroy(this.gameObject);
        yield return null;

    }
}
