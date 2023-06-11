using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Transform target;
    public float speedEnemy;
   

    void Start()
    {
    }


    void Update()  
    {
        this.transform.LookAt(target);
        Vector3 direction = target.position - this.transform.position;
        this.transform.position += direction.normalized * speedEnemy * Time.deltaTime;
    }


}
