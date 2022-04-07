using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool paused = false;
    public GameObject panel;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        ClickButton();
        }
    }
    public void ClickButton()
    {
        if (!paused)
        {
            Time.timeScale = 0;
            paused = true;
            panel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            paused = false;
            panel.SetActive(false);
        }
    }
    
}
