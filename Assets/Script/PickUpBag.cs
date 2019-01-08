using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBag : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject bagBtn;

    private void Update()
    {
        if (GameController.BagDone == true)
        {
            Destroy(gameObject);
        }

        if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
        {
            if (Input.GetKey(KeyCode.B))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                    GameController.BagDone = true;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            bagBtn.SetActive(true);
            GameController.BagDone = true;
        }
    }
}
