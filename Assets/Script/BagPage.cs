using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPage : MonoBehaviour {

    public Dialogue warning;

    public Dialogue dialogue;

    public static bool bagOpen;
    public GameObject Bag;

    public GameObject BagUI;

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

    public GameObject GunDone;
    public GameObject BowDone;
    public GameObject PanDone;
    public GameObject IronDone;
    public GameObject LoveDone;
    public GameObject LaserDone;

    void Update()
    {
        if (bagOpen == true)
            GameController.bagIsOpen = true;
        else
            GameController.bagIsOpen = false;

        if (GameController.BagDone == true)
            BagUI.SetActive(true);

        if (GameController.isPause != true && GameController.isMenu!=true || GameController.bagIsOpen == true)
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
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }

            if (GetWords.PanWords == 3)
            {
                GetWords.PanWords++;
                panPhare = 1;
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }

            if (GetWords.IronWords == 4)
            {
                GetWords.IronWords++;
                ironPhare = 1;
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }

            if (GetWords.LoveWords == 4)
            {
                GetWords.LoveWords++;
                lovePhare = 1;
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }

            if (GetWords.LaserWords == 5)
            {
                GetWords.LaserWords++;
                laserPhare = 1;
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }
        }
    }

    public void gunPage()
    {
        if (gunPhare == 0)
        {
            changePage(GunIn);
        }
        else if (gunPhare == 1)
        {
            changePage(GunWordSide);
        }
        else
        {
            changePage(GunDone);
        }
    }

    public void bowPage()
    {
        if (bowPhare == 0)
        {
            changePage(BowIn);
        }
        else if (bowPhare == 1)
        {
            changePage(BowWordSide);
        }
        else
        {
            changePage(BowDone);
        }
    }

    public void panPage()
    {
        if (panPhare == 0)
        {
            changePage(PanIn);
        }
        else if (panPhare == 1)
        {
            changePage(PanWordSide);
        }
        else
        {
            changePage(PanDone);
        }
    }

    public void ironPage()
    {
        if (ironPhare == 0)
        {
            changePage(IronIn);
        }
        else if (ironPhare == 1)
        {
            changePage(IronWordSide);
        }
        else
        {
            changePage(IronDone);
        }
    }

    public void lovePage()
    {
        if (lovePhare == 0)
        {
            changePage(LoveIn);
        }
        else if (lovePhare == 1)
        {
            changePage(LoveWordSide);
        }
        else
        {
            changePage(LoveDone);
        }
    }
    public void laserPage()
    {
        if (laserPhare == 0)
        {
            changePage(LaserIn);
        }
        else if (laserPhare == 1)
        {
            changePage(LaserWordSide);
        }
        else
        {
            changePage(LaserDone);
        }
    }

    public void bagPage()
    {
        if (Tutorial.BagCantClose == true && GameController.GunDone == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(warning);
        }
        else
        {
            audioController.Btn = true;
            bagOpen = true;

            Bag.SetActive(true);

            // 全部unvisible,只有背包打开
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
            GunDone.SetActive(false);
            BowDone.SetActive(false);
            PanDone.SetActive(false);
            IronDone.SetActive(false);
            LoveDone.SetActive(false);
            LaserDone.SetActive(false);
        }
    }

    public void allClose()
    {
        // 如果拿到U了，不组装出枪，就不能关掉背包哦~
        if (Tutorial.BagCantClose == true && GameController.GunDone == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(warning);
        }
        else
        {
            audioController.Btn = true;
            // 全部不见
            bagOpen = false;

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
            GunDone.SetActive(false);
            BowDone.SetActive(false);
            PanDone.SetActive(false);
            IronDone.SetActive(false);
            LoveDone.SetActive(false);
            LaserDone.SetActive(false);

            GameController.bagIsOpen = false;
        }
    }


    void changePage(GameObject show)
    {
        audioController.Btn = true;
        allClose();
        bagOpen = true;
        show.SetActive(true);
    }

    public void openBag()
    {
        // 打开背包
        if (Tutorial.BagCantClose == true && GameController.GunDone == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(warning);
        }
        else
        {
            bagOpen = !bagOpen;
            if (bagOpen == true)
            {
                audioController.Btn = true;
                Bag.SetActive(true);
            }
            else
            {
                allClose();
            }
        }
    }
}
