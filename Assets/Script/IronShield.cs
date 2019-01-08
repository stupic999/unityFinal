using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronShield : MonoBehaviour {

    public GameObject Player;

    float NextFire = 1f;
    float FireCD;

    public AudioClip IronSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (FireCD < NextFire)
        {
            FireCD += NextFire;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (WeopenController.useWhatWeopen == 4)
            {
            if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
            {
                if (other.tag == "Emy")
                {                                        
                    PlayerController player = Player.GetComponent<PlayerController>();                   
                    if (player.invincibleTime<=0)
                    {
                        audioSource.PlayOneShot(IronSound);
                    }
                    MonsterController monsterDamage = other.GetComponent<MonsterController>();
                    player.DamagePlayer(monsterDamage.Damage / 5);
                }
                else if (other.tag == "EmyWord")
                {
                    PlayerController player = Player.GetComponent<PlayerController>();
                    if (player.invincibleTime <= 0)
                    {
                        audioSource.PlayOneShot(IronSound);                        
                    }
                    MonsterWordController monsterDamage = other.GetComponent<MonsterWordController>();
                    player.DamagePlayer(monsterDamage.Damage / 5);
                }
                else if (other.tag == "Boss")
                {
                    PlayerController player = Player.GetComponent<PlayerController>();
                    if (player.invincibleTime <= 0)
                    {
                        audioSource.PlayOneShot(IronSound);
                    }
                    BossController bossDamage = other.GetComponent<BossController>();                    
                    player.DamagePlayer(bossDamage.Damage / 5);
                    
                }
                else if (other.tag == "EmyBullet")
                {
                    audioSource.PlayOneShot(IronSound);
                }
            }
        }
    }

}
