using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public float speed;

    public int score;  // これが敵を倒すと得られる点数になる
    private ScoreManager sm;


    // Use this for initialization
    void Start () {
        // 「ScoreManagerオブジェクト」に付いている「ScoreManagerスクリプト」の情報を取得して「sm」の箱に入れる。
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
         transform.position += new Vector3(speed, 0f, 0f);
        //this.gameObject.transform.Translate(Random.Range(0.05f, 0.1f), Random.Range(-0.1f, 0.1f), 0);
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

}
