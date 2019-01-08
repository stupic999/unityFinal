using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour {

    public GameObject bullet;
    public Transform laser;
    float NextFire = 0.1f;
    float FireCD;

    public AudioClip LaserSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (WeopenController.useWhatWeopen == 6)
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
        audioSource.PlayOneShot(LaserSound);
        Instantiate(bullet, laser.position, laser.rotation);
    }
}
