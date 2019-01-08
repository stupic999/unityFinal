using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanHit : MonoBehaviour
{

    int damage = 80;
    float NextFire = 1f;
    float FireCD;
    public GameObject panHit;
    public bool Hit;

    public Animator playerAnim;

    void Update()
    {
        if (Hit == true)
        {
            playerAnim.SetBool("Hit", false);
            Hit = false;
        }

        if (GameController.PanDone == true)
        {
            if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
            {
                if (FireCD < NextFire)
                {
                    FireCD += Time.deltaTime;
                }
                if (Input.GetMouseButton(0) && FireCD >= NextFire)
                {
                    playerAnim.SetBool("Hit", true);
                    Hit = true;
                    FireCD = 0;                    
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (WeopenController.useWhatWeopen == 3)
        {
            if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
            {
                if (other.tag == "Emy")
                {
                    if (Hit == true)
                    {                        
                        MonsterController emy = other.GetComponent<MonsterController>();
                        emy.DamageEmy(damage);
                        Hit = false;
                        playerAnim.SetBool("Hit", false);
                    }
                }
                else if (other.tag == "EmyWord")
                {
                    if (Hit == true)
                    {
                        playerAnim.SetBool("Hit", false);
                        MonsterWordController emy = other.GetComponent<MonsterWordController>();
                        emy.DamageEmy(damage);
                        Hit = false;                        
                    }
                }
            }
        }
    }
}
