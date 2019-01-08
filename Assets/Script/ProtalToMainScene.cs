using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtalToMainScene : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject Controller;
    public GameObject Player;
    public Camera MainCamare;
    public GameObject MonsterRoot;
    public GameObject UI;
    public GameObject MonsterTSearch;

    private void OnTriggerStay(Collider other)
    {
        if (Tutorial.Bdone == true && other.tag == "Player")
        {
            ChangeRoom.GoToMainRoom();
            DontDestroyOnLoad(Controller);
            DontDestroyOnLoad(Player);
            DontDestroyOnLoad(MainCamare);
            MainCamare.orthographicSize = 5;
            DontDestroyOnLoad(UI);
            DontDestroyOnLoad(MonsterRoot);
            Player.transform.position = new Vector3(-48, 0, -23);
            GameController.lastCheckPoint = new Vector3(0, 0, 0);
            DontDestroyOnLoad(MonsterTSearch);
            GameController.scene = 1;
            MonsterRoot.SetActive(true);
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
