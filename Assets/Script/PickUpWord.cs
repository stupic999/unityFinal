using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWord : MonoBehaviour {

    public Dialogue dialogue;
    CheckPoint saveCheckPoint;
    Tutorial tutorial;

    private void Start()
    {
        saveCheckPoint = GameObject.FindGameObjectWithTag("GM").GetComponent<CheckPoint>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            saveCheckPoint.lastCheckPoint = transform.position;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Destroy(gameObject);
            if (transform.tag == "U")
            {
                GetWords.gotU = true;
                BagPage.bagOpen = true;
                Tutorial.BagCantClose = true;
                tutorial = GetComponentInParent<Tutorial>();
                tutorial.monster1In();
            }
            if (transform.tag == "B")
            {
                GetWords.gotB = true;
                Tutorial.Bdone = true;
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
