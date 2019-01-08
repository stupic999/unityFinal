using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWord : MonoBehaviour {

    public Dialogue dialogue;
    Tutorial tutorial;

    private void Update()
    {
        if (transform.tag == "U" && GameController.UDone == true)
        {
            Destroy(gameObject);
        }

        if (transform.tag == "B" && GameController.BDone == true)
        {
            Destroy(gameObject);
        }

        if (transform.tag == "W" && GameController.WDone == true)
        {
            Destroy(gameObject);
        }

        if (transform.tag == "P" && GameController.PDone == true)
        {
            Destroy(gameObject);
        }

        if (transform.tag == "I" && GameController.IDone == true)
        {
            Destroy(gameObject);
        }

        if (transform.tag == "R" && GameController.RDone == true)
        {
            Destroy(gameObject);
        }

        if (transform.tag == "V" && GameController.VDone == true)
        {
            Destroy(gameObject);
        }

        if (transform.tag == "S" && GameController.SDone == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            audioController.GotWord = true;
            GameController.lastCheckPoint = transform.position;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Destroy(gameObject);
            if (transform.tag == "U")
            {
                BagPage.bagOpen = true;
                Tutorial.BagCantClose = true;
                tutorial = GetComponentInParent<Tutorial>();
                tutorial.monster1In();
                GetWords.gotU = true;
            }
            if (transform.tag == "B")
            {                
                Tutorial.Bdone = true;
                GetWords.gotB = true;
            }
            if (transform.tag == "W")
            {
                GetWords.gotW = true;
            }
            if (transform.tag == "P")
            {
                GetWords.gotP = true;
            }
            if (transform.tag == "I")
            {
                GetWords.gotI = true;
            }
            if (transform.tag == "R")
            {
                GetWords.gotR = true;
            }
            if (transform.tag == "V")
            {
                GetWords.gotV = true;
            }
            if (transform.tag == "S")
            {
                GetWords.gotS = true;
            }
        }
    }
}
