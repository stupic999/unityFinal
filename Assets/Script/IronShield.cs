using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronShield : MonoBehaviour {

    public GameObject Player;

    private void OnTriggerStay(Collider other)
    {
        if (GameController.IronDone == true)
        {
           if (GameController.isPause != true && GameController.bagIsOpen != true)
            {
                if (other.tag == "Emy")
                {
                    MonsterController monsterDamge = other.GetComponent<MonsterController>();
                    PlayerController player = Player.GetComponent<PlayerController>();
                    player.DamagePlayer(monsterDamge.Damage / 5);
                }
            }
        }
    }

}
