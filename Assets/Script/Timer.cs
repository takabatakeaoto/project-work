using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class Timer : MonoBehaviour
{

    //　トータル制限時間
    public float totalTime;
    //　制限時間（分）
    [SerializeField]
    public int minute;
    //　制限時間（秒）
    [SerializeField]
    public float seconds;
    //　前回Update時の秒数
    public float oldSeconds;
    public Text timerText;


   

    

    void Start()
    {
        totalTime =  seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();


    }

    public void Update()
    {



    
        //　制限時間が0秒以下なら何もしない
        if (totalTime <= 0f)
        {
            return;
        }
        //　一旦トータルの制限時間を計測；
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        //　再設定
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        //　タイマー表示用UIテキストに時間を表示する
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        //　制限時間以下になったらコンソールに『制限時間終了』という文字列を表示する
         if (totalTime <= 0f)
        {
        GameObject.Find("Panel").GetComponent<FadeController2>().isFadeOut = true;



       // SceneManager.LoadScene("gameover");
        }
    }

  
    
   
}
