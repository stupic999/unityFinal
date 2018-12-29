using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtalToMainScene : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject DialogController;
    public GameObject Player;
    public GameObject Bag;
    public GameObject GameController;
    public GameObject MainCamare;
    public GameObject BagController;

    private void OnTriggerStay(Collider other)
    {
        if (Tutorial.Bdone == true && other.tag == "Player")
        {
            ChangeRoom.GoToMainRoom();
            DontDestroyOnLoad(DialogController);
            DontDestroyOnLoad(Player);
            DontDestroyOnLoad(Bag);
            DontDestroyOnLoad(GameController);
            DontDestroyOnLoad(MainCamare);
            DontDestroyOnLoad(BagController);
            Player.transform.position = new Vector3(0, 0, 0);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (Tutorial.Bdone == false && other.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
