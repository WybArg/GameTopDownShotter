using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 platformSize;
    private Vector3 movement;

    public float speed;
    private float frameRotation = 0;
    public float speedRotation;

    void Start()
    {

    }


    void Update()
    {
        frameRotation = 0;
        movement = Vector3.zero;
        movement.z = Input.GetAxisRaw("Vertical");

        transform.Translate(movement.normalized * speed * Time.deltaTime);
        Vector3 newPos = this.transform.position;
       
        newPos.x = Mathf.Clamp(newPos.x, -platformSize.x, platformSize.x);
        newPos.z = Mathf.Clamp(newPos.z, -platformSize.y, platformSize.y);

        this.transform.position = newPos;



        if (Input.GetKey(KeyCode.A))
        {
            frameRotation += -speedRotation * Time.deltaTime;
            this.transform.Rotate(0, frameRotation, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            frameRotation += speedRotation * Time.deltaTime;
            this.transform.Rotate(0, frameRotation, 0);
        }

    }





}
