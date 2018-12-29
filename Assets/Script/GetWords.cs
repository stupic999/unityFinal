using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWords : MonoBehaviour {

    // 还未亮起的字母，也就是未获得的字母
    public GameObject EmptyGunU;
    public GameObject EmptyBowB;
    public GameObject EmptyBowW;
    public GameObject EmptyPanP;
    public GameObject EmptyIronI;
    public GameObject EmptyIronR;
    public GameObject EmptyLaserR2;
    public GameObject EmptyLoveV;
    public GameObject EmptyLaserS;

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
            GetWordPro(U, EmptyGunU);
            gunWords++;
            gotU = false;
        }

        if (gotB == true)
        {
            GetWordPro(B, EmptyBowB);
            bowWords++;
            gotB = false;
        }

        if (gotW == true)
        {
            GetWordPro(W, EmptyBowW);
            bowWords++;
            gotW = false;
        }

        if (gotP == true)
        {
            GetWordPro(P, EmptyPanP);
            panWords++;
            gotP = false;
        }

        if (gotI == true)
        {
            GetWordPro(I, EmptyIronI);
            ironWords++;
            gotI = false;
        }

        if (gotR == true)
        {
            GetWordPro(R, EmptyIronR);
            GetWordPro(R2,EmptyLaserR2);
            ironWords++;
            laserWords++;
            gotR = false;
        }

        if (gotV == true)
        {
            GetWordPro(V, EmptyLoveV);
            loveWords++;
            gotV = false;
        }

        if (gotS == true)
        {
            GetWordPro(S, EmptyLaserS);
            laserWords++;
            gotS = false;
        }

    }

    void GetWordPro(GameObject show, GameObject des)
    {
        show.SetActive(true);
        Destroy(des);
    }
}
