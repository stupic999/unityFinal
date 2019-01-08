using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomStartDialog : MonoBehaviour {

    public Dialogue dialogue;

    // Use this for initialization
    void Start() {
        if (GameController.firstRoomStarted == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            GameController.firstRoomStarted = true;
        }
    }
}
