using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtalToMainScene : MonoBehaviour {

    CheckPoint saveCheckPoint;

    public Dialogue dialogue;
    public GameObject DialogController;
    public GameObject Player;
    public GameObject Bag;
    public GameObject GameController;
    public GameObject MainCamare;
    public GameObject BagController;

    private void Start()
    {
        saveCheckPoint = GameObject.FindGameObjectWithTag("GM").GetComponent<CheckPoint>();
    }

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
            saveCheckPoint.lastCheckPoint = new Vector3(0, 0, 0);
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
