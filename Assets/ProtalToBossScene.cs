using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtalToBossScene : MonoBehaviour
{

    public Dialogue dialogue;
    public GameObject Controller;
    public GameObject Player;
    public Camera MainCamare;
    public GameObject MonsterRoot;
    public GameObject UI;
    public GameObject MonsterTSearch;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            ChangeRoom.GoToBossRoom();
            DontDestroyOnLoad(Controller);
            DontDestroyOnLoad(Player);
            DontDestroyOnLoad(MainCamare);
            MainCamare.orthographicSize = 12;
            DontDestroyOnLoad(UI);
            DontDestroyOnLoad(MonsterRoot);
            Player.transform.position = new Vector3(-13, 0, -13);
            GameController.lastCheckPoint = new Vector3(-13, 0, -13);
            DontDestroyOnLoad(MonsterTSearch);
            GameController.scene = 2;
            MonsterRoot.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
