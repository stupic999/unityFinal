using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowWord : MonoBehaviour {

    string[] word = new string[3] { "", "", "" };
    public GameObject B;
    public GameObject O;
    public GameObject W;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    /*
    public GameObject BowDone;
    public GameObject BowWordSide;
    */
    bool Bin;
    bool Oin;
    bool Win;
 
    public void clickOnB()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "B")
            {
                word[i] = "";
                B.transform.position = new Vector2(441.6f, 104.6f);
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
                O.transform.position = new Vector2(768, 104.6f);
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
                W.transform.position = new Vector2(1094.4f, 104.6f);
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
            Debug.Log("BowDone");
            /*
            GunDone.SetActive(true);
            Destroy(GunWordSide);
            */
        }
    }
}
