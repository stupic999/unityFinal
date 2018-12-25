﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public Transform gun;
    
    float NextFire = 0.3f;
    float FireCD;

    void Update()
    {
        if (GameController.GunDone == true)
        {
            if (GameController.isPause != true && GameController.bagIsOpen != true)
            {
                if (FireCD < NextFire)
                    FireCD += Time.deltaTime;

                if (Input.GetMouseButton(0) && FireCD >= NextFire)
                {
                    Effect();
                    FireCD = 0;
                }
            }

        }
    }

    public void Effect()
    {
        Instantiate(bullet, gun.position, gun.rotation);
    }
}
