using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int score;  // これが敵を倒すと得られる点数になる
    private ScoreManager sm;



    // Use this for initialization
    void Start()
    {

        // 「ScoreManagerオブジェクト」に付いている「ScoreManagerスクリプト」の情報を取得して「sm」の箱に入れる。
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        //StartCoroutine("TimeBomb");
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision) //衝突時の処理
    {
        //Destroy(this.gameObject);
        if (collision.gameObject.tag == "Target")
        //タグで限定（他のオブジェクトに衝突した場合は呼び出さない
        {
           
            this.transform.localScale = Vector3.zero; //みえない大きさにする
            //sm.AddScore(score);
        }
    }
}

//IEnumerator TimeBomb()
   // {
        //yield return new WaitForSeconds(RemainingTime);
        //Destroy(this.gameObject);
       // yield return null;

    //}
//