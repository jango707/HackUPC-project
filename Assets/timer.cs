using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float countdown = 100;

    public Text Timer;

    public Canvas TimeUp;

    void Update()
    {
         countdown -= Time.deltaTime;
         Timer.text = Mathf.RoundToInt(countdown).ToString();
        if (countdown <= 0)
        {
            TimeOver();
        }
    }

    public void TimeOver()
    {
        Time.timeScale = 0;
        TimeUp.gameObject.SetActive(true);
    }
}
