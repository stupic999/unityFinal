using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronWord : MonoBehaviour {

    public Dialogue dialogue;

    public GameObject IronUI;

    string[] word = new string[4] { "", "", "", "" };

    public GameObject I;
    public GameObject O;
    public GameObject R;
    public GameObject N;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    Vector3 iPos;
    Vector3 rPos;
    Vector3 oPos;
    Vector3 nPos;
    public GameObject IronDone;
    public GameObject IronWordSide;

    // 字母放对地方就会true
    bool Iin;
    bool Oin;
    bool Rin;
    bool Nin;

    private void Start()
    {
        iPos = I.transform.position;
        rPos = R.transform.position;
        oPos = O.transform.position;
        nPos = N.transform.position;
    }

    public void clickOnI()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "I")
            {
                word[i] = "";
                I.transform.position = iPos;
                Iin = false;
                break;
            }
            // 如果没有重复，就找空的位子填上去
            else if (word[i] == "" && Iin == false)
            {
                word[i] = "I";
                Iin = true;
                BoxIn(i, I);
                ironDone();
                break;
            }
        }
    }

    public void clickOnO()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "O")
            {
                word[i] = "";
                O.transform.position = oPos;
                Oin = false;
                break;
            }
            else if (word[i] == "" && Oin == false)
            {
                word[i] = "O";
                BoxIn(i, O);
                Oin = true;
                ironDone();
                break;
            }
        }
    }

    public void clickOnR()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "R")
            {
                word[i] = "";
                R.transform.position = rPos;
                Rin = false;
                break;
            }
            else if (word[i] == "" && Rin == false)
            {
                word[i] = "R";
                BoxIn(i, R);
                Rin = true;
                ironDone();
                break;
            }
        }
    }

    public void clickOnN()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "N")
            {
                word[i] = "";
                N.transform.position = nPos;
                Nin = false;
                break;
            }
            else if (word[i] == "" && Nin == false)
            {
                word[i] = "N";
                BoxIn(i, N);
                Nin = true;
                ironDone();
                break;
            }
        }
    }

    void BoxIn(int i, GameObject word)
    {
        if (i == 0)
        {
            word.transform.position = Box1.transform.position;
        }
        else if (i == 1)
        {
            word.transform.position = Box2.transform.position;
        }
        else if (i == 2)
        {
            word.transform.position = Box3.transform.position;
        }
        else
        {
            word.transform.position = Box4.transform.position;
        }
    }

    void ironDone()
    {
        if (word[0] == "I" && word[1] == "R" && word[2] == "O" && word[3] == "N")
        {
            GameController.IronDone = true;
            IronUI.SetActive(true);
            IronDone.SetActive(true);
            IronWordSide.SetActive(false);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            BagPage.ironPhare = 2;
        }
    }
}
