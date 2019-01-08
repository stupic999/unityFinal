using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTuturialDie : MonoBehaviour {
    public Dialogue dialogue;

    public void PortalShow()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
