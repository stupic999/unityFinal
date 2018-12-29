using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPage : MonoBehaviour {

    public Dialogue dialogue;

    public static bool bagOpen = false;
    public GameObject Bag;
    public GameObject WeopenSystem;

    // 武器拼字的阶段，0为字未筹齐，1为筹齐已可以拼字，2已拼好
    public static int gunPhare;
    public static int bowPhare;
    public static int panPhare;
    public static int ironPhare;
    public static int lovePhare;
    public static int laserPhare;

    // 还未拿到字母的画面
    public GameObject GunIn;
    public GameObject BowIn;
    public GameObject PanIn;
    public GameObject IronIn;
    public GameObject LoveIn;
    public GameObject LaserIn;

    // 武器拼字画面
    public GameObject GunWordSide;
    public GameObject BowWordSide;
    public GameObject PanWordSide;
    public GameObject IronWordSide;
    public GameObject LoveWordSide;
    public GameObject LaserWordSide;

    void Update()
    {
        if (bagOpen == true)
            GameController.bagIsOpen = true;
        else
            GameController.bagIsOpen = false;

        if (GameController.isPause != true || GameController.bagIsOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                openBag();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                allClose();
            }

            if (GetWords.GunWords == 3)
            {
                GetWords.GunWords++;
                gunPhare = 1;
            }

            if (GetWords.BowWords == 3)
            {
                GetWords.BowWords++;
                bowPhare = 1;
            }

            if (GetWords.PanWords == 3)
            {
                GetWords.PanWords++;
                panPhare = 1;
            }

            if (GetWords.IronWords == 4)
            {
                GetWords.IronWords++;
                ironPhare = 1;
            }

            if (GetWords.LoveWords == 4)
            {
                GetWords.LoveWords++;
                lovePhare = 1;
            }

            if (GetWords.LaserWords == 5)
            {
                GetWords.LaserWords++;
                laserPhare = 1;
            }
        }
    }

    public void gunPage()
    {
        if (gunPhare == 0)
        {
            changePage(GunIn);
            WeopenSystem.SetActive(true);
        }
        else if (gunPhare == 1)
            changePage(GunWordSide);
        /* 要加上完成画面
         else
         changTye(GunDone,Bag);
         */
    }

    public void bowPage()
    {
        if (bowPhare == 0)
        {
            changePage(BowIn);
            WeopenSystem.SetActive(true);
        }
        else if (bowPhare == 1)
            changePage(BowWordSide);
    }

    public void panPage()
    {
        if (panPhare == 0)
        {
            changePage(PanIn);
            WeopenSystem.SetActive(true);
        }
        else if (panPhare == 1)
            changePage(PanWordSide);
    }

    public void ironPage()
    {
        if (ironPhare == 0)
        {
            changePage(IronIn);
            WeopenSystem.SetActive(true);
        }
        else if (ironPhare == 1)
            changePage(IronWordSide);
    }

    public void lovePage()
    {
        if (lovePhare == 0)
        {
            changePage(LoveIn);
            WeopenSystem.SetActive(true);
        }
        else if (lovePhare == 1)
            changePage(LoveWordSide);
    }
    public void laserPage()
    {
        if (laserPhare == 0)
        {
            changePage(LaserIn);
            WeopenSystem.SetActive(true);
        }
        else if (laserPhare == 1)
            changePage(LaserWordSide);
    }

    public void bagPage()
    {
        bagOpen = true;

        Bag.SetActive(true);

        // 全部unvisible,只有背包打开
        WeopenSystem.SetActive(false);
        GunIn.SetActive(false);
        BowIn.SetActive(false);
        PanIn.SetActive(false);
        IronIn.SetActive(false);
        LoveIn.SetActive(false);
        LaserIn.SetActive(false);
        GunWordSide.SetActive(false);
        BowWordSide.SetActive(false);
        PanWordSide.SetActive(false);
        IronWordSide.SetActive(false);
        LoveWordSide.SetActive(false);
        LaserWordSide.SetActive(false);
    }

    public void allClose()
    {
        // 如果拿到U了，不组装出枪，就不能关掉背包哦~
        if (Tutorial.BagCantClose == true && GameController.GunDone == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else
        {
            // 全部不见
            bagOpen = false;

            WeopenSystem.SetActive(false);
            GunIn.SetActive(false);
            BowIn.SetActive(false);
            PanIn.SetActive(false);
            IronIn.SetActive(false);
            LoveIn.SetActive(false);
            LaserIn.SetActive(false);
            GunWordSide.SetActive(false);
            BowWordSide.SetActive(false);
            PanWordSide.SetActive(false);
            IronWordSide.SetActive(false);
            LoveWordSide.SetActive(false);
            LaserWordSide.SetActive(false);
            Bag.SetActive(false);
            GameController.bagIsOpen = false;
        }
    }


    void changePage(GameObject show)
    {
        Bag.SetActive(false);
        GunIn.SetActive(false);
        BowIn.SetActive(false);
        PanIn.SetActive(false);
        IronIn.SetActive(false);
        LoveIn.SetActive(false);
        LaserIn.SetActive(false);

        show.SetActive(true);
    }

    void openBag()
    {
        // 打开背包
        bagOpen = !bagOpen;
        if (bagOpen == true)
        {
            Bag.SetActive(true);
        }
        else
        {
            allClose();
        }
    }
}
