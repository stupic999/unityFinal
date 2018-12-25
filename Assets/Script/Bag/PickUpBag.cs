using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBag : MonoBehaviour {

    public Dialogue dialogue;

    private void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Destroy(gameObject);
        }
    }
}
