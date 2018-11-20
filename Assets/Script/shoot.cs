using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform gun;
    public float speed;
    public Transform Muzzle;
    public GameObject Player;
    
    public float timeBetweenShot;
    public float timer ;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("TimeOutDestroy");
    }

    // Update is called once per frame
    //public void OnClick()
    void Update()

    {

        timer += Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && timer > timeBetweenShot)

        {
            Shoot();
            timer = 0.0f;
        }
     
    }
    void Shoot()
    {
       
        GameObject Bullet = Instantiate(BulletPrefab) as GameObject;
        Bullet.transform.position = this.transform.position;
        Bullet.transform.Rotate(new Vector3(0, 0, -transform.root.localEulerAngles.y));
        Vector3 shootforce = this.transform.forward * speed;
        Bullet.GetComponent<Rigidbody>().AddForce(shootforce);
        Player.GetComponent<AudioSource>().Play();
       
    }

    IEnumerator TimeOutDestroy()

    {
        {
            
            yield return new WaitForSeconds(5);
            yield return null;
        }
    }
}