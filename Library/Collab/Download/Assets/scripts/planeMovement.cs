using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class planeMovement : NetworkBehaviour {

    public Rigidbody2D rb;
    


    public float speed = 2f;

    float MovementY;
    float MovementX;

    private float Y_pos;
    private float X_pos;



    // Update is called once per frame
    void Update () {
        if (hasAuthority== false )
        {
            return;
        }

        int delta = scrollScript.heartRate - scrollScript.initialHeartRate;

        if (delta > 5)
        {
            //they are stressing out
            //slow down the plane
            speed = 0.5f;
        }
        else if (delta < -5)
        {
            //they are relaxed
            speed = 2f;
        }
        else
        {
            speed = 1.75f;
        }

        MovementY = Input.GetAxisRaw("Vertical") * (speed / 10);
        MovementX = Input.GetAxisRaw("Horizontal") * (speed / 10);

        Y_pos = Mathf.Clamp(rb.transform.position.y, -5, 5);
        X_pos = Mathf.Clamp(rb.transform.position.x, -10, 10);
        rb.transform.position =new Vector3(X_pos,Y_pos, rb.transform.position.z);
    }

    public void FixedUpdate()
    {
        Move(MovementX,MovementY);
    }
    public void Move(float i, float j )
    {
        Vector2 displacement = new Vector2(rb.position.x+i, rb.position.y+j);
        rb.transform.position = displacement;

    }
}
