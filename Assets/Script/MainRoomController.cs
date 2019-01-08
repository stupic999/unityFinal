using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoomController : MonoBehaviour {

    public Dialogue dialogue;

    // Use this for initialization
    void Start()
    {
        if (GameController.mainRoomStarted == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            GameController.mainRoomStarted = true;
        }
    }
}
