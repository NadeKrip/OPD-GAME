﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenGame()
    {
        SceneManager.LoadScene("OPD RESET");
    }
    public void OpenMenu()
    {
        SceneManager.LoadScene("Main Screen");
    }
}
