using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTheGame : MonoBehaviour {

    public void StartGame()
    {
        audioController.Btn = true;
        ChangeRoom.GoToFirstRoom();
    }
    public void StartScene()
    {
        ChangeRoom.GoToStart();
    }
}
