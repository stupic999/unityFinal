using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserWord : MonoBehaviour {

    // 可能考虑用empty当字母回去的坐标，或者用screan hight之类的
    string[] word = new string[5] { "", "", "", "", "" };

    public GameObject L;
    public GameObject A;
    public GameObject S;
    public GameObject E;
    public GameObject R;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    public GameObject Box5;
    /*
    public GameObject LoveDone;
    public GameObject LoveWordSide;
    */

    // 字母放对地方就会true
    bool Lin;
    bool Ain;
    bool Sin;
    bool Ein;
    bool Rin;
    

    public void clickOnL()
    {
        for (int i = 0; i < word.Length; i++)
        {
            // 先侦测一遍阵列，看有没有G
            if (word[i] == "L")
            {
                word[i] = "";
                L.transform.position = new Vector2(380.5f, 111.2f);
                Lin = false;
                break;
            }
            // 如果没有重复，就找空的位子填上去
            if (word[i] == "" && Lin == false)
            {
                word[i] = "L";
                Lin = true;
                BoxIn(i, L);
                LaserDone();
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
                A.transform.position = new Vector2(570.8f, 104.6f);
                Ain = false;
                break;
            }
            else if (word[i] == "" && Ain == false)
            {
                word[i] = "A";
                BoxIn(i, A);
                Ain = true;
                LaserDone();
                break;
            }
        }
    }

    

    public void clickOnS()
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "S")
            {
                word[i] = "";
                S.transform.position = new Vector2(761, 111.2f);
                Sin = false;
                break;
            }
            else if (word[i] == "" && Sin == false)
            {
                word[i] = "S";
                BoxIn(i, S);
                Sin = true;
                LaserDone();
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
                E.transform.position = new Vector2(951.3f, 111.2f);
                Ein = false;
                break;
            }
            else if (word[i] == "" && Ein == false)
            {
                word[i] = "E";
                BoxIn(i, E);
                Ein = true;
                LaserDone();
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
                R.transform.position = new Vector2(1141.5f, 111.2f);
                Rin = false;
                break;
            }
            else if (word[i] == "" && Rin == false)
            {
                word[i] = "R";
                BoxIn(i, R);
                Rin = true;
                LaserDone();
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
        else if (i == 3)
        {
            word.transform.position = Box4.transform.position;
        }
        else
        {
            word.transform.position = Box5.transform.position;
        }
    }

    void LaserDone()
    {
        if (word[0] == "L" && word[1] == "A" && word[2] == "S" && word[3] == "E" && word[4]=="R")
        {
            Debug.Log("LaserDone");
            /*
            IronDone.SetActive(true);
            Destroy(IronWordSide);
            */
        }
    }
}
