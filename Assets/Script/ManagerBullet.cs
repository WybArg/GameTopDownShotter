using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBullet : MonoBehaviour
{
    private float time;
    public float delayBullet;
    public GameObject bullet;
    public Transform posBullet;

    void Start()
    {
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && time <= 0)
        {
            Instantiate(bullet, posBullet.position, posBullet.rotation);
            time = delayBullet;
        }
        time -= Time.deltaTime;
    }
}
