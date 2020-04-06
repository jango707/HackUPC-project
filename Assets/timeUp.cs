using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeUp : MonoBehaviour
{
    public Text FinalDisplay;

    public void Start()
    {
        FinalDisplay.text = "Great Job! You have achieved a total of "+ coins.PlayerScores[coins.PlayerName] + " points. You're average heartrate was "+scrollScript.heartRate+" " +
            "Would you like to play again?";
    }
}
