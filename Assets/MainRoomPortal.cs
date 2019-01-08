using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoomPortal : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject mainRoomPortal;
    GameObject Player;
    int done;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update () {     
        if (done == 0)
        {
            if (GameController.UDone == true && GameController.BDone == true && GameController.WDone == true && GameController.PDone == true && GameController.IDone == true && GameController.RDone == true && GameController.VDone == true)
            {
                if (GameController.monstersDie >= 17)
                {
                    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                    mainRoomPortal.SetActive(true);
                    mainRoomPortal.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y,Player.transform.position.z+2f);
                    done++;
                }
            }
        }
    }
}
