using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeopenController : MonoBehaviour
{

    int useWhatWeopen=1;
    public GameObject gun;
    public GameObject bow;
    public GameObject pan;
    public GameObject iron;
    public GameObject love;
    public GameObject laser;

    // Update is called once per frame
    void Update()
    {
        ChooseWeopen();

        if (useWhatWeopen == 1)
        {
            gun.SetActive(true);

            bow.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
        }
        if (useWhatWeopen == 2)
        {
            bow.SetActive(true);

            gun.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
        }
        if (useWhatWeopen == 3)
        {
            pan.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
        }
        if (useWhatWeopen == 4)
        {
            iron.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            pan.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
        }
        if (useWhatWeopen == 5)
        {
            love.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            laser.SetActive(false);
        }
        if (useWhatWeopen == 6)
        {
            laser.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
        }
    }

    // 按快捷键1~6对应武器
    void ChooseWeopen()
    {
        if (GameController.isPause != true && GameController.bagIsOpen != true)
        {
            if (GameController.GunDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    useWhatWeopen = 1;
                    Debug.Log("Gun");
                }
            }
            if (GameController.BowDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    useWhatWeopen = 2;
                    Debug.Log("Bow");
                }
            }
            if (GameController.PanDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    useWhatWeopen = 3;
                    Debug.Log("Pan");
                }
            }
            if (GameController.IronDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    useWhatWeopen = 4;
                    Debug.Log("Iron");
                }
            }
            if (GameController.LoveDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    useWhatWeopen = 5;
                    Debug.Log("Love");
                }
            }
            if (GameController.LaserDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    useWhatWeopen = 6;
                    Debug.Log("Laser");
                }
            }
        }
    }
}
