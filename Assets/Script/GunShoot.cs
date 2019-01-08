using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour {

    public GameObject bullet;
    public Transform gun;
 //  int damage = 10;
    float NextFire = 0.3f;
    float FireCD;

    public AudioClip GunSound;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (WeopenController.useWhatWeopen==1)
        {
            if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
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
        audioSource.PlayOneShot(GunSound);
        Instantiate(bullet, gun.position, gun.rotation);
    }
}
