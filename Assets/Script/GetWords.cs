using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWords : MonoBehaviour {

    // 字母
    public GameObject G;
    public GameObject N;
    public GameObject N2;
    public GameObject N3;
    public GameObject U;
    public GameObject B;
    public GameObject O;
    public GameObject O2;
    public GameObject O3;
    public GameObject W;
    public GameObject P;
    public GameObject A;
    public GameObject A2;
    public GameObject I;
    public GameObject R;
    public GameObject R2;
    public GameObject L;
    public GameObject L2;
    public GameObject V;
    public GameObject E;
    public GameObject E2;
    public GameObject S;

    // 有没有拿到字母
    public static bool gotU;
    public static bool gotB;
    public static bool gotW;
    public static bool gotP;
    public static bool gotI;
    public static bool gotR;
    public static bool gotV;
    public static bool gotS;

    // 每个武器的字母数量
    int gunWords=2;
    int bowWords=1;
    int panWords=2;
    int ironWords=2;
    int loveWords=3;
    int laserWords = 3;
    public static int GunWords;
    public static int BowWords;
    public static int PanWords;
    public static int IronWords;
    public static int LoveWords;
    public static int LaserWords;

    void Update()
    {
        if (GunWords < gunWords)
            GunWords = gunWords;

        if (BowWords < bowWords)
            BowWords = bowWords;

        if (PanWords < panWords)
            PanWords = panWords;

        if (IronWords < ironWords)
            IronWords = ironWords;

        if (LoveWords < loveWords)
            LoveWords = loveWords;

        if (LaserWords < laserWords)
            LaserWords = laserWords;

        // 如果拿到了字母，会怎么样？
        if (gotU == true)
        { 
            gunWords++;
            gotU = false;
            GameController.UDone = true;
        }

        if (gotB == true)
        { 
            bowWords++;
            gotB = false;
            GameController.BDone = true;
        }

        if (gotW == true)
        {
            bowWords++;
            gotW = false;
            GameController.WDone = true;
        }

        if (gotP == true)
        {
            panWords++;
            gotP = false;
            GameController.PDone = true;
        }

        if (gotI == true)
        {
            ironWords++;
            gotI = false;
            GameController.IDone = true;
        }

        if (gotR == true)
        {
            ironWords++;
            laserWords++;
            gotR = false;
            GameController.RDone = true;
        }

        if (gotV == true)
        {
            loveWords++;
            gotV = false;
            GameController.VDone = true;
        }

        if (gotS == true)
        {
            laserWords++;
            gotS = false;
            GameController.SDone = true;
        }

        if (GameController.UDone == true)
        {
            U.SetActive(true);
        }

        if (GameController.BDone == true)
        {
            B.SetActive(true);
        }

        if (GameController.WDone == true)
        {
            W.SetActive(true);
        }

        if (GameController.PDone == true)
        {
            P.SetActive(true);
        }

        if (GameController.IDone == true)
        {
            I.SetActive(true);
        }

        if (GameController.RDone == true)
        {
            R.SetActive(true);
            R2.SetActive(true);
        }

        if (GameController.VDone == true)
        {
            V.SetActive(true);
        }

        if (GameController.SDone == true)
        {
            S.SetActive(true);
        }
    }
}
