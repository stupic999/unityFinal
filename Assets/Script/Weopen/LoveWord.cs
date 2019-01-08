using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveWord : MonoBehaviour {

    public Dialogue dialogue;

    public GameObject LoveUI;

    string[] word = new string[4] { "", "", "", "" };

    public GameObject L;
    public GameObject O;
    public GameObject V;
    public GameObject E;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    Vector3 lPos;
    Vector3 oPos;
    Vector3 vPos;
    Vector3 ePos;
    public GameObject LoveDone;
    public GameObject LoveWordSide;

    // 字母放对地方就会true
    bool Lin;
    bool Oin;
    bool Vin;
    bool Ein;

    private void Start()
    {
        lPos = L.transform.position;
        oPos = O.transform.position;
        vPos = V.transform.position;
        ePos = E.transform.position;
    }

    public void clickOnL()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "L")
            {
                word[i] = "";
                L.transform.position =lPos;
                Lin = false;
                break;
            }
            // 如果没有重复，就找空的位子填上去
            if (word[i] == "" && Lin == false)
            {
                word[i] = "L";
                Lin = true;
                BoxIn(i, L);
                loveDone();
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
                loveDone();
                break;
            }
        }
    }

    public void clickOnV()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "V")
            {
                word[i] = "";
                V.transform.position = vPos;
                Vin = false;
                break;
            }
            else if (word[i] == "" && Vin == false)
            {
                word[i] = "V";
                BoxIn(i, V);
                Vin = true;
                loveDone();
                break;
            }
        }
    }

    public void clickOnE()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "E")
            {
                word[i] = "";
                E.transform.position = ePos;
                Ein = false;
                break;
            }
            else if (word[i] == "" && Ein == false)
            {
                word[i] = "E";
                BoxIn(i, E);
                Ein = true;
                loveDone();
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

    void loveDone()
    {
        if (word[0] == "L" && word[1] == "O" && word[2] == "V" && word[3] == "E") 
        {
            audioController.WeopenDone = true;
            GameController.LoveDone = true;
            LoveUI.SetActive(true);
            LoveDone.SetActive(true);
            LoveWordSide.SetActive(false);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            BagPage.lovePhare = 2;
        }
    }
}
