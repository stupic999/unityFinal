using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour {

    public GameObject bullet;
    public Transform laser;
 //   int damage = 5;
    float NextFire = 0.1f;
    float FireCD;

    void Update()
    {
        if (GameController.LaserDone == true)
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
        Instantiate(bullet, laser.position, laser.rotation);
    }
}
