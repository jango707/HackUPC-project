using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Net;
using System;
using UnityEngine.UI;

public class scrollScript : MonoBehaviour
{

    //this is the variable that will vary depending on the heartbeat of the user
    public static float speed = 0.5f;

    int initialReadingsSum = 0;
    int initialReadingsCount = 0;

    public static int initialHeartRate = 0;
    public static int heartRate = 0;

    //public static float PlaneSpeed;
    //public static float CoinRate;

    public Text heartbeatText;

    // Update is called once per frame
    void Update()
    {
        heartRate = getHeartRate();

        if (initialReadingsCount < 2)
        {
            Console.WriteLine("Here1");
            initialReadingsCount += 1;
            initialReadingsSum += heartRate;
            System.Threading.Thread.Sleep(500);
        }
        else if (initialReadingsCount == 2)
        {
            initialReadingsCount += 1;
            Console.WriteLine("Here");
            initialHeartRate = initialReadingsSum / 2;
        }
        else
        {
            Debug.Log("Initial Heart Rate Computed as: " + initialHeartRate);

            heartbeatText.text = "Heart Rate:     " + heartRate;

            Vector2 offset = new Vector2(Time.time * -speed, 0);

            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }

    }

    int getHeartRate()
    {
        int heartRate = 0;
        string text = System.IO.File.ReadAllText("Assets/data.json");
        text = text.Substring(14);
        text = text.Remove(text.Length - 1);
        heartRate = Int32.Parse(text);

        return heartRate;
    }

}
