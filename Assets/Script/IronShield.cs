using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronShield : MonoBehaviour {

    public GameObject Player;

    private void OnTriggerStay(Collider other)
    {
        if (WeopenController.useWhatWeopen == 4)
            {
            if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
            {
                if (other.tag == "Emy")
                {
                    MonsterController monsterDamage = other.GetComponent<MonsterController>();
                    PlayerController player = Player.GetComponent<PlayerController>();
                    player.DamagePlayer(monsterDamage.Damage / 5);
                }
                else if (other.tag == "EmyWord")
                {
                    MonsterWordController monsterDamage = other.GetComponent<MonsterWordController>();
                    PlayerController player = Player.GetComponent<PlayerController>();
                    player.DamagePlayer(monsterDamage.Damage / 5);
                }
            }
        }
    }

}
