using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public Canvas TimeUp;
    public Canvas Start;
    public Canvas instruction1;
    public Canvas instructions2;
    public void StartGame()
    {
        SceneManager.LoadScene("flight");

        TimeUp.gameObject.SetActive(false);
        Time.timeScale = 1;
        timer.countdown = 100;

    }

    public void firstButton()
    {
        Start.gameObject.SetActive(false);
        instruction1.gameObject.SetActive(true);

    }
    public void secondButton()
    {
        instruction1.gameObject.SetActive(false);
        instructions2.gameObject.SetActive(true);

    }

}
