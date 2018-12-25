using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanWord : MonoBehaviour {

    string[] word = new string[3] { "", "", "" };

    public GameObject P;
    public GameObject A;
    public GameObject N;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    /*
    public GameObject PanDone;
    public GameObject PanWordSide;
    */

    // 字母放对地方就会true
    bool Pin;
    bool Ain;
    bool Nin;

    public void clickOnP()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "P")
            {
                word[i] = "";
                P.transform.position = new Vector2(441.6f, 104.6f);
                Pin = false;
                break;
            }
            // 如果没有重复，就找空的位子填上去
            if (word[i] == "" && Pin == false)
            {
                word[i] = "P";
                Pin = true;
                BoxIn(i, P);
                panDone();
                break;
            }
        }
    }

    public void clickOnA()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "A")
            {
                word[i] = "";
                A.transform.position = new Vector2(768, 104.6f);
                Ain = false;
                break;
            }
            else if (word[i] == "" && Ain == false)
            {
                word[i] = "A";
                BoxIn(i, A);
                Ain = true;
                panDone();
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
                N.transform.position = new Vector2(1094.4f, 104.6f);
                Nin = false;
                break;
            }
            else if (word[i] == "" && Nin == false)
            {
                word[i] = "N";
                BoxIn(i, N);
                Nin = true;
                panDone();
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

    void panDone()
    {
        if (word[0] == "P" && word[1] == "A" && word[2] == "N")
        {
            Debug.Log("PanDone");
            /*
            GunDone.SetActive(true);
            Destroy(GunWordSide);
            */
        }
    }
}
