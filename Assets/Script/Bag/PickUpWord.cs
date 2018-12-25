using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWord : MonoBehaviour {

    public Dialogue dialogue;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Destroy(gameObject);
            if (transform.name == "U")
            {
                GetWords.gotU = true;
            }
            if (transform.name == "B")
            {
                GetWords.gotB = true;
            }
            if (transform.name == "W")
            {
                GetWords.gotW = true;
            }
            if (transform.name == "P")
            {
                GetWords.gotP = true;
            }
            if (transform.name == "I")
            {
                GetWords.gotI = true;
            }
            if (transform.name == "R")
            {
                GetWords.gotR = true;
            }
            if (transform.name == "V")
            {
                GetWords.gotV = true;
            }
            if (transform.name == "S")
            {
                GetWords.gotS = true;
            }
        }
    }
}
