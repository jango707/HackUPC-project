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

    public Text heartbeatText;

    // Update is called once per frame
    void Update()
    {
        int heartRate = getHeartRate();

        heartbeatText.text = "Your Heart Rate: "+heartRate;

        Vector2 offset = new Vector2(Time.time * speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = offset;
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
