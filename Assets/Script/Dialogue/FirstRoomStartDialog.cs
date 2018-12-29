using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomStartDialog : MonoBehaviour {

    public Dialogue dialogue;

    // Use this for initialization
    void Start() {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
