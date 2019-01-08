using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //パネルのイメージを操作するのに必要
using UnityEngine.SceneManagement;





public class ImageScript : MonoBehaviour {

    float fadeSpeed = 0.05f;
    float red, green, blue, alfa;
    public bool isFadeOut = false;
    public bool isFadeIn = false;
    Image fadeImage;

	// Use this for initialization
	void Start () {
       
       fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
       alfa = fadeImage.color.a;

 

    }

    // Update is called once per frame
    void Update()
    {





        if (alfa >= 1)
        {
            isFadeIn = true;
        }
        if (isFadeIn)
        {


            StartFadeIn();
        }





        if (isFadeOut)
        {
            StartFadeOut();
        }
    }





    void StartFadeOut()
    {
        fadeImage.enabled = true;  // a)パネルの表示をオンにする
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            isFadeOut = false;
                //fadeImage.enabled = false;
        }
    }

    void StartFadeIn()
    {
        alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
        SetAlpha();                      //b)変更した不透明度パネルに反映する
        if (alfa <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            isFadeIn = false;
           // fadeImage.enabled = false;    //d)パネルの表示をオフにする
        }
    }
    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa * 0.8f);
    }

}
