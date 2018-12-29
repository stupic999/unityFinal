using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowShoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform bowFirePoint1;
    public Transform bowFirePoint2;
    public Transform bowFirePoint3;
   // int damage = 5;
    float NextFire = 0.5f;
    float FireCD;

    void Update()
    {
        if (GameController.BowDone == true)
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
        Instantiate(bullet, bowFirePoint1.position, bowFirePoint1.rotation);
        Instantiate(bullet, bowFirePoint2.position, bowFirePoint2.rotation);
        Instantiate(bullet, bowFirePoint3.position, bowFirePoint3.rotation);
    }
}