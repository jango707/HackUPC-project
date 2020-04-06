using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float countdown = 1f;
    private int randomX;
    public GameObject go;
    public GameObject chicken;

    public Transform[] CoinSpawns;
    void Update()
    {
        int delta = scrollScript.heartRate - scrollScript.initialHeartRate;

        Debug.Log("Heart-Rate delta: " + delta);

        if (delta > 5)
        {
            //they are stressed out
            //they are going to get more chickens than coins
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                randomX = Random.Range(0, 10);
                if (randomX > 4)
                {
                    SpawnChicken();
                }
                else
                {
                    Spawn(); //Spawn Coin
                }


                countdown = 1f;

            }
        }
        else if (delta < -5)
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                randomX = Random.Range(0, 10);
                if (randomX > 8)
                {
                    SpawnChicken();
                }
                else
                {
                    Spawn(); //Spawn Coin
                }


                countdown = 1f;

            }
        }
        else
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                randomX = Random.Range(0, 20);
                if (randomX > 9)
                {
                    SpawnChicken();
                }
                else
                {
                    Spawn(); //Spawn Coin
                }


                countdown = 1f;

            }
        }

        
    }

     public void Spawn()
    {
        Quaternion rotation = CoinSpawns[Random.Range(0,CoinSpawns.Length)].transform.rotation;
        GameObject coin = Instantiate(go, CoinSpawns[Random.Range(0,CoinSpawns.Length)].position, rotation);
        Destroy(coin, 10f);

    }
    public void SpawnChicken()
    {
        Quaternion rotation = CoinSpawns[Random.Range(0, CoinSpawns.Length)].transform.rotation;
        GameObject chickenGO = Instantiate(chicken, CoinSpawns[Random.Range(0, CoinSpawns.Length)].position, rotation);
        Destroy(chicken, 10f);

    }
}
