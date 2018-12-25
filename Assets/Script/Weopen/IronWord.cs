using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronWord : MonoBehaviour {

    string[] word = new string[4] { "", "", "", "" };

    public GameObject I;
    public GameObject O;
    public GameObject R;
    public GameObject N;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    /*
    public GameObject LoveDone;
    public GameObject LoveWordSide;
    */

    // 字母放对地方就会true
    bool Iin;
    bool Oin;
    bool Rin;
    bool Nin;

    public void clickOnI()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "I")
            {
                word[i] = "";
                I.transform.position = new Vector2(418.6f, 111.2f);
                Iin = false;
                break;
            }
            // 如果没有重复，就找空的位子填上去
            else if (word[i] == "" && Iin == false)
            {
                word[i] = "I";
                Iin = true;
                BoxIn(i, I);
                LoveDone();
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
                O.transform.position = new Vector2(646.9f, 111.2f);
                Oin = false;
                break;
            }
            else if (word[i] == "" && Oin == false)
            {
                word[i] = "O";
                BoxIn(i, O);
                Oin = true;
                LoveDone();
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
                R.transform.position = new Vector2(875.2f, 111.2f);
                Rin = false;
                break;
            }
            else if (word[i] == "" && Rin == false)
            {
                word[i] = "R";
                BoxIn(i, R);
                Rin = true;
                LoveDone();
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
                N.transform.position = new Vector2(1103.5f, 111.2f);
                Nin = false;
                break;
            }
            else if (word[i] == "" && Nin == false)
            {
                word[i] = "N";
                BoxIn(i, N);
                Nin = true;
                LoveDone();
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

    void LoveDone()
    {
        if (word[0] == "I" && word[1] == "R" && word[2] == "O" && word[3] == "N")
        {
            Debug.Log("IronDone");
            /*
            IronDone.SetActive(true);
            Destroy(IronWordSide);
            */
        }
    }
}
