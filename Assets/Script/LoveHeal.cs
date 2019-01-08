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

    public AudioClip LoveSound;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

        void Update()
    {
        LovePic.fillAmount = FireCD / 60;       
        if (GameController.LoadLoveCD == true)
        {
            FireCD = GameController.LoveFireCD;
            GameController.LoadLoveCD = false;
        }
        GameController.LoveFireCD = FireCD;

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
                if (WeopenController.useWhatWeopen == 5)
                {
                    if (Input.GetMouseButton(0) && FireCD >= NextFire)
                    {
                        audioSource.PlayOneShot(LoveSound);
                        FireCD = 0;
                        PlayerController player = Player.GetComponent<PlayerController>();
                        player.HealPlayer(heal);
                        playerAnim.SetBool("Heal", true);
                    }
                }
            }
        }
    }
}
