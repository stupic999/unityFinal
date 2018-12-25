using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveWord : MonoBehaviour {

    string[] word = new string[4] { "", "", "", "" };

    public GameObject L;
    public GameObject O;
    public GameObject V;
    public GameObject E;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    /*
    public GameObject LoveDone;
    public GameObject LoveWordSide;
    */

    // 字母放对地方就会true
    bool Lin;
    bool Oin;
    bool Vin;
    bool Ein;

    public void clickOnL()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "L")
            {
                word[i] = "";
                L.transform.position = new Vector2(418.6f, 111.2f);
                Lin = false;
                break;
            }
            // 如果没有重复，就找空的位子填上去
            if (word[i] == "" && Lin == false)
            {
                word[i] = "L";
                Lin = true;
                BoxIn(i, L);
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

    public void clickOnV()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "V")
            {
                word[i] = "";
                V.transform.position = new Vector2(875.2f, 111.2f);
                Vin = false;
                break;
            }
            else if (word[i] == "" && Vin == false)
            {
                word[i] = "V";
                BoxIn(i, V);
                Vin = true;
                LoveDone();
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
                E.transform.position = new Vector2(1103.5f, 111.2f);
                Ein = false;
                break;
            }
            else if (word[i] == "" && Ein == false)
            {
                word[i] = "E";
                BoxIn(i, E);
                Ein = true;
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
        if (word[0] == "L" && word[1] == "O" && word[2] == "V" && word[3] == "E") 
        {
            Debug.Log("LoveDone");
            /*
            LoveDone.SetActive(true);
            Destroy(LoveWordSide);
            */
        }
    }
}
