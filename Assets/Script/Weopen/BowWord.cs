using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowWord : MonoBehaviour {

    public Dialogue dialogue;

    public GameObject BowUI;

    string[] word = new string[3] { "", "", "" };
    public GameObject B;
    public GameObject O;
    public GameObject W;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    Vector3 bPos;
    Vector3 oPos;
    Vector3 wPos;

    public GameObject BowDone;
    public GameObject BowWordSide;

    bool Bin;
    bool Oin;
    bool Win;

    private void Start()
    {
        bPos = B.transform.position;
        oPos = O.transform.position;
        wPos = W.transform.position;
    }

    public void clickOnB()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "B")
            {
                word[i] = "";
                B.transform.position = bPos;
                Bin = false;
                break;
            }
            // 如果没有重复，就找空的位子填上去
            if (word[i] == "" && Bin == false)
            {
                word[i] = "B";
                Bin = true;
                BoxIn(i, B);
                bowDone();
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
                bowDone();
                break;
            }
        }
    }

    public void clickOnW()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "W")
            {
                word[i] = "";
                W.transform.position = wPos;
                Win = false;
                break;
            }
            else if (word[i] == "" && Win == false)
            {
                word[i] = "W";
                BoxIn(i, W);
                Win = true;
                bowDone();
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
        else
        {
            word.transform.position = Box3.transform.position;
        }
    }

    void bowDone()
    {
        if (word[0] == "B" && word[1] == "O" && word[2] == "W")
        {
            audioController.WeopenDone = true;
            GameController.BowDone = true;
            BowUI.SetActive(true);
            BowDone.SetActive(true);
            BowWordSide.SetActive(false);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            BagPage.bowPhare = 2;
        }
    }
}
