using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public float speed;
    public int RemainingTime;
    // public float Random1;
    // public float Random2;
    public int score;  // これが敵を倒すと得られる点数になる
    public ScoreManager sm;


    // Use this for initialization
    void Start () {
        StartCoroutine("TimeBomb");
        // 「ScoreManagerオブジェクト」に付いている「ScoreManagerスクリプト」の情報を取得して「sm」の箱に入れる。
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(speed, 0f, 0f);
        //this.gameObject.transform.Translate(Random.Range(Random1, Random2), 0,0);
        
    }

    void OnCollisionEnter(Collision collision) //衝突時の処理
    {
        //Debug.Log(score);
        //Destroy(this.gameObject);
        if (collision.gameObject.tag == "Bullet")
        //タグで限定（他のオブジェクトに衝突した場合は呼び出さない
        {
            this.transform.localScale = Vector3.zero; //みえない大きさにする
            sm.AddScore(score);
            Destroy(collision.gameObject);
        
            if (gameObject.tag == "Animal")
            {
                GameObject.Find("red").GetComponent<ImageScript>().isFadeOut=true;
            }
        }

       // if (collision.gameObject.CompareTag("Bullet")) 
       // {
            //Debug.Log("Bullet Tag");
           
       // }

        if (collision.gameObject.CompareTag("explosion"))
        {
            this.transform.localScale = Vector3.zero;
          
            Destroy(collision.gameObject,0.5f);
            sm.AddScore(score);



            if (gameObject.tag == "Animal")
            {
                GameObject.Find("red").GetComponent<ImageScript>().isFadeOut = true;
           }
        }

    }
    IEnumerator TimeBomb()
    {
        yield return new WaitForSeconds(RemainingTime);
        Destroy(this.gameObject);
        yield return null;

    }
}
