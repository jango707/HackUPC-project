using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int _score = 0;

    public Text score1;

    //public static Dictionary<string, int> PlayerScores = new Dictionary<string, int>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if(collision.collider.tag == "Coin")
        {
            string PlayerName = collision.collider.name;
            if (PlayerScores.ContainsKey(PlayerName))
            {
                PlayerScores[PlayerName] += 10;
            } else
            {
                PlayerScores.Add(PlayerName, 10);
            }
            Debug.Log(PlayerName + ": " + PlayerScores[PlayerName]);
        }*/
    }
}
