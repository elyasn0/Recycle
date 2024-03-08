using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pipe : MonoBehaviour
{
    public int pipeColour;

    [Header("UI stars")]


    public GameObject panel;
    public void Awake()
    {
        counterText.text = "0 / " + goal;
    }
    public TextMesh counterText;

    [SerializeField]
    private int counter;
    private int goal = 30;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GreenBall" && pipeColour==0||
            other.tag == "RedBall" && pipeColour == 1 ||
            other.tag == "BlueBall" && pipeColour == 2 ||
            other.tag == "YellowBall" && pipeColour == 3 ||
            other.tag == "PurpleBall" && pipeColour == 4)
        {
            Destroy(other.gameObject);
            counter++;
            //timer.SetActive(true);
            counterText.text = counter + " / " + goal;
            if (counter == goal)
            {
                FindObjectOfType<AudioManager>().Play("VictorySound");
                panel.SetActive(true);
            }
        }
        else Destroy(other.gameObject);
    }

}
