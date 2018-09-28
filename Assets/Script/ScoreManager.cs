using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 忘れずに！

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    //private int score = 0;
    public Text scoreLabel;

    void Start()
    {

        scoreLabel = GameObject.Find("ScoreLabel").GetComponent<Text>();
        scoreLabel.text = "SCORE：" + score;
    }

    // スコアを増加させるメソッド
    // 外部からアクセスするためpublicで定義する
    public void AddScore(int amount)
    {

        score += amount;
        scoreLabel.text = "SCORE：" + score;
    }
    
}