using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static bool isPause;
    public static bool bagIsOpen;
    public static bool gameOver;

    // Weopen
    public static bool GunDone;
    public static bool BowDone;
    public static bool PanDone;
    public static bool IronDone;
    public static bool LoveDone;
    public static bool LaserDone;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F4))
        {
            GunDone = true;
            BowDone = true;
            PanDone = true;
            IronDone = true;
            LoveDone = true;
            LaserDone = true;
        }

        if (gameOver == true)
        {
            ChangeRoom.GoToGameOver();
        }
    }
}
