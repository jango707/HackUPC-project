using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreChecker : MonoBehaviour
{
    public Canvas Win;
    // Update is called once per frame
    void Update()
    {
        if (score._score >= 100)
        {
            Win.gameObject.SetActive(true);
        }
    }
}
