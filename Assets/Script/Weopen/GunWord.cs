using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWord : MonoBehaviour {

    public Dialogue dialogue;

    string[] word = new string[3] { "", "", "" };

    public GameObject GunUI;

    public GameObject G;
    public GameObject U;
    public GameObject N;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    Vector3 gPos;
    Vector3 uPos;
    Vector3 nPos;
    public GameObject GunDone;
    public GameObject GunWordSide;

    // 字母放对地方就会true
    bool Gin;
    bool Nin;
    bool Uin;

    private void Start()
    {
        gPos = G.transform.position;
        uPos = U.transform.position;
        nPos = N.transform.position;
    }

    public void clickOnG()
    {
        if (GameController.isPause != true)
        {
            for (int i = 0; i < word.Length; i++)
            {
                // 先侦测一遍阵列，看有没有G
                if (word[i] == "G")
                {
                    word[i] = "";
                    G.transform.position = gPos;
                    Gin = false;
                    break;
                }
                // 如果没有重复，就找空的位子填上去
                if (word[i] == "" && Gin == false)
                {
                    word[i] = "G";
                    Gin = true;
                    BoxIn(i, G);
                    gunDone();
                    break;
                }
            }
        }
    }

    public void clickOnN()
    {
        if (GameController.isPause != true)
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
                    gunDone();
                    break;
                }
            }
        }
    }

    public void clickOnU()
    {
        if (GameController.isPause != true)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == "U")
                {
                    word[i] = "";
                    U.transform.position = uPos;
                    Uin = false;
                    break;
                }
                else if (word[i] == "" && Uin == false)
                {
                    word[i] = "U";
                    BoxIn(i, U);
                    Uin = true;
                    gunDone();
                    break;
                }
            }
        }
    }

    void BoxIn(int i,GameObject word)
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

    void gunDone()
    {
        if (word[0] == "G" && word[1] == "U" && word[2] == "N" && GameController.GunDone==false)
        {
            GameController.GunDone = true;
            GunUI.SetActive(true);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);            
            GunDone.SetActive(true);
            GunWordSide.SetActive(false);
            BagPage.gunPhare = 2;
        }
    }
}
