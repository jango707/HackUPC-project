using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject go;

   
    public static float speed = 2f;
    

   

   
    void Start()
    {
        rb.velocity = new Vector2(-1*speed, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Player")
        {
                
            
            Destroy(go);
        }
    }
    

   

}

