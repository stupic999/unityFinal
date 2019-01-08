using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoveHeal : MonoBehaviour {

    public Animator playerAnim;

    int heal = 50;
    float NextFire = 60f;
    public GameObject Player;
    public Image LovePic;
    float FireCD=60;

    void Update()
    {
        LovePic.fillAmount = FireCD / 60;

        if (FireCD == 0)
        {
            playerAnim.SetBool("Heal", false);
        }

        if(GameController.LoveDone == true)
            {
            if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
            {
                if (FireCD < NextFire)
                    FireCD += Time.deltaTime;

                if (Input.GetMouseButton(0) && FireCD >= NextFire)
                {
                    FireCD = 0;
                    PlayerController player = Player.GetComponent<PlayerController>();
                    player.HealPlayer(heal);
                    playerAnim.SetBool("Heal", true);
                }
            }
        }
    }
}
