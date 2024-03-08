using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    private GUIStyle style = new GUIStyle();
    private int accumulator = 0;
    private int counter = 0;
    private float timer = 0f;

    private void Start()
    {
        //Application.targetFrameRate = 30;
        Time.timeScale = 1;
        style.normal.textColor = Color.white;
        style.fontSize = 32;
        style.fontStyle = FontStyle.Bold;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 34), "FPS:" + counter, style); //счетчик фпс 
    }

    private void Update()
    {
        accumulator++;
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            timer = 0;
            counter = accumulator;
            accumulator = 0;
        }
    }
}
