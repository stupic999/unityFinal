using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeopenController : MonoBehaviour
{
    public Animator playerAnim;

    public static int useWhatWeopen;
    public GameObject gun;
    public GameObject bow;
    public GameObject pan;
    public GameObject iron;
    public GameObject love;
    public GameObject laser;

    public GameObject GunUI;
    public GameObject BowUI;
    public GameObject PanUI;
    public GameObject IronUI;
    public GameObject LoveUI;
    public GameObject LaserUI;

    // Update is called once per frame
    void Update()
    {
        if (GameController.GunDone == true)
            GunUI.SetActive(true);
        if (GameController.BowDone == true)
            BowUI.SetActive(true);
        if (GameController.PanDone == true)
            PanUI.SetActive(true);
        if (GameController.IronDone == true)
            IronUI.SetActive(true);
        if (GameController.LoveDone == true)
            LoveUI.SetActive(true);
        if (GameController.LaserDone == true)
            LaserUI.SetActive(true);

        ChooseWeopen();

        if (useWhatWeopen == 1)
        {
            gun.SetActive(true);

            bow.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
            allFalse();
            playerAnim.SetBool("useGun", true);
        }
        else if (useWhatWeopen == 2)
        {
            bow.SetActive(true);

            gun.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
            allFalse();
            playerAnim.SetBool("useBow", true);
        }
        else if (useWhatWeopen == 3)
        {
            pan.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
            allFalse();
            playerAnim.SetBool("usePan", true);
        }
        else if (useWhatWeopen == 4)
        {
            iron.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            pan.SetActive(false);
            love.SetActive(false);
            laser.SetActive(false);
            allFalse();
            playerAnim.SetBool("useIron", true);
        }
        else if (useWhatWeopen == 5)
        {
            love.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            laser.SetActive(false);
            allFalse();
            playerAnim.SetBool("useLove", true);
        }
        else if (useWhatWeopen == 6)
        {
            laser.SetActive(true);

            gun.SetActive(false);
            bow.SetActive(false);
            pan.SetActive(false);
            iron.SetActive(false);
            love.SetActive(false);
            allFalse();
            playerAnim.SetBool("useLaser", true);
        }
        else
        {
            allFalse();
        }
    }
    
    public void useGun()
    {
        if (GameController.GunDone == true)
        {
            useWhatWeopen = 1;
        }
    }

    public void useBow()
    {
        if (GameController.BowDone == true)
        {
            useWhatWeopen = 2;
        }
    }

    public void usePan()
    {
        if (GameController.PanDone == true)
        {
            useWhatWeopen = 3;
        }
    }

    public void useIron()
    {
        if (GameController.IronDone == true)
        {
            useWhatWeopen = 4;
        }
    }

    public void useLove()
    {
        if (GameController.LoveDone == true)
        {
            useWhatWeopen = 5;
        }
    }

    public void useLaser()
    {
        if (GameController.LaserDone == true)
        {
            useWhatWeopen = 6;
        }
    }

    void allFalse()
    {
        playerAnim.SetBool("useGun", false);
        playerAnim.SetBool("useBow", false);
        playerAnim.SetBool("usePan", false);
        playerAnim.SetBool("useIron", false);
        playerAnim.SetBool("useLove", false);
        playerAnim.SetBool("useLaser", false);
    }

    // 按快捷键1~6对应武器
    void ChooseWeopen()
    {
        if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
        {
            if (GameController.GunDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    useWhatWeopen = 1;
                }
            }
            if (GameController.BowDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    useWhatWeopen = 2;
                }
            }
            if (GameController.PanDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    useWhatWeopen = 3;
                }
            }
            if (GameController.IronDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    useWhatWeopen = 4;
                }
            }
            if (GameController.LoveDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    useWhatWeopen = 5;
                }
            }
            if (GameController.LaserDone == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    useWhatWeopen = 6;
                }
            }
        }
    }
}
