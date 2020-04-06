using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject go;

    public static Text ScoreText;

    public static string PlayerName = "";

    public static float speed = 2f;

    public static Dictionary<string, int> PlayerScores = new Dictionary<string, int>();

    public static bool CoinPickUP = false;

    void Start()
    {
        rb.velocity = new Vector2(-1*speed, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Player")
        {
            CoinPickUP = true;
            if (PlayerName == "")
            {
                PlayerName = collision.collider.name;
            }

            Destroy(go);

            if (PlayerScores.ContainsKey(PlayerName))
            {
                PlayerScores[PlayerName] += 10;
            } else
            {
                PlayerScores.Add(PlayerName, 10);
            }
            Debug.Log(PlayerName + ": " + PlayerScores[PlayerName]);
        }

    }




}

