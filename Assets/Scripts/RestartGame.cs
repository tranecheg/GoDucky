﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
