using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanHit : MonoBehaviour {

    int damage = 30;
    float NextFire = 1f;
    float FireCD;

    void Update()
    {
        if (GameController.PanDone == true)
        {
            if (GameController.isPause != true && GameController.bagIsOpen != true)
            {
                if (FireCD < NextFire)
                    FireCD += Time.deltaTime;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Emy")
        {
            if (GameController.PanDone == true)
            {
                if (GameController.isPause != true && GameController.bagIsOpen != true)
                {
                    if (Input.GetMouseButton(0) && FireCD >= NextFire)
                    {
                        FireCD = 0;
                        MonsterController emy = other.GetComponent<MonsterController>();
                        emy.DamageEmy(damage);
                    }
                }
            }
        }
    }
}
