using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;
public class ComeBack : MonoBehaviour
{
 

    // Use this for initialization
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ScoreManager.score = 0;

            SceneManager.LoadScene("Main");
        }

    }
}
