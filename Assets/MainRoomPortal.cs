using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoomPortal : MonoBehaviour {

    public GameObject mainRoomPortal;
    GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update () {
        if (GameController.UDone == true && GameController.BDone == true && GameController.WDone == true && GameController.PDone == true && GameController.IDone == true && GameController.RDone == true && GameController.VDone == true)
        {
            if (GameController.monstersDie >= 17)
            {
                mainRoomPortal.SetActive(true);
                mainRoomPortal.transform.position = (Player.transform.position);
            }
        }
    }
}
