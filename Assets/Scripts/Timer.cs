using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 10;
    public int timeLeft;

    public Text timeLeftText;
    public GameObject panel;

    public void Update()
    {
        time -= Time.deltaTime;
        timeLeft = (int)time;

        if (time < 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            timeLeftText.text =""+timeLeft;
        }
    }
}
