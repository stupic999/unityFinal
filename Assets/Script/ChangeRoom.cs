﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRoom : MonoBehaviour {

        CheckPoint saveCheckPoint;

    public static void GoToStart()
    {
        SceneManager.LoadScene("Start");
    }

    public static void GoToFirstRoom()
    {
        SceneManager.LoadScene("FirstRoom");
    }

    public static void GoToMainRoom()
    {
        SceneManager.LoadScene("MainRoom");
    }

    public static void GoToBossRoom()
    {
        SceneManager.LoadScene("BossRoom");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
