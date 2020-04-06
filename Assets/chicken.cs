using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chicken : MonoBehaviour
{
    public GameObject go;
    public Rigidbody2D rb;
    public static float speed = 2f;
    public static bool ChickenDead = false;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(-1 * speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            ChickenDead = true;
            if (coins.PlayerName == "")
            {
                coins.PlayerName = collision.collider.name;
            }

            Destroy(go);

            if (coins.PlayerScores.ContainsKey(coins.PlayerName))
            {
                coins.PlayerScores[coins.PlayerName] -= 10;
            }
            else
            {
                coins.PlayerScores.Add(coins.PlayerName, -10);
            }
            Debug.Log(coins.PlayerName + ": " + coins.PlayerScores[coins.PlayerName]);
        }
    }

}
