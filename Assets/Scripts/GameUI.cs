using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject resultsPanel;
    public GameObject pausePanel;
    public GameObject rayListner;
    public int level;
    public int nextLevel;

    private bool pauseBool=false;

    public void Pause()
    {
        if (pauseBool==false)
        {
            pausePanel.SetActive(true);
            rayListner.SetActive(false);
            Time.timeScale = 0;
            pauseBool = true;
        }
        else
        {
            pausePanel.SetActive(false);
            rayListner.SetActive(true);
            Time.timeScale = 1;
            pauseBool = false;
        }
      
    }

    public void Restart()
    {
        SceneManager.LoadScene("Scenes/"+level);
    }

    public void LoadNextLevel()
    {
        level++;
        try
        {
            SceneManager.LoadScene("Scenes/" + nextLevel);
        }
        catch
        {
            Debug.Log("Scene Scenes/" + nextLevel + "not found");
        }
    }
}
