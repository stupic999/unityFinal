using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveHeal : MonoBehaviour {

    int heal = 50;
    float NextFire = 60f;
    public GameObject Player;
    float FireCD=60;

    void Update()
    {
        if (GameController.LoveDone == true)
        {
            if (GameController.isPause != true && GameController.bagIsOpen != true)
            {
                if (FireCD < NextFire)
                    FireCD += Time.deltaTime;

                if (Input.GetMouseButton(0) && FireCD >= NextFire)
                {
                    FireCD = 0;
                    PlayerController player = Player.GetComponent<PlayerController>();
                    player.HealPlayer(heal);
                }
            }
        }
    }
}
