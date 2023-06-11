using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float time;
    public float speedBullet;
    public float durationBullet;

    void Start()
    {
        
    }


    void Update()
    {
        time += Time.deltaTime;
        this.transform.Translate(Vector3.forward.normalized * speedBullet * Time.deltaTime);
        
        if(time >= durationBullet)
        {
            Destroy(this.gameObject);
        }
    }



    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 10)
        {
            Destroy(other.gameObject);
        }
    }







}
