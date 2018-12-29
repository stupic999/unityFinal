using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRoom : MonoBehaviour {

    public void GoToFirstRoom()
    {
        SceneManager.LoadScene("FirstRoom");
    }

    public static void GoToMainRoom()
    {
        SceneManager.LoadScene("MainRoom");
    }

    public static void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
