using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSearch : MonoBehaviour {

    MonsterChase monsterChase;
    MonsterController monsterController;
    MonsterWordController monsterWordController;

    private void Start()
    {
        monsterChase = GetComponentInChildren<MonsterChase>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player" || other.tag=="Bullet")
        monsterChase.foundPlayer = true;
        monsterController = GetComponentInChildren<MonsterController>();
        if (monsterController == null)
        {
            monsterWordController = GetComponentInChildren<MonsterWordController>();
            if (monsterWordController.monsterNum == 0)
            {
                GameController.MonsterTFound = true;
            }
            else
            {
                GameController.Monster0Found = true;
            }
        }
        else
        {
            if (monsterController.monsterNum == 1)
            {
                GameController.Monster1Found = true;
            }
            if (monsterController.monsterNum == 2)
            {
                GameController.Monster2Found = true;
            }
            if (monsterController.monsterNum == 3)
            {
                GameController.Monster3Found = true;
            }
            if (monsterController.monsterNum == 4)
            {
                GameController.Monster4Found = true;
            }
            if (monsterController.monsterNum == 5)
            {
                GameController.Monster5Found = true;
            }
            if (monsterController.monsterNum == 6)
            {
                GameController.Monster6Found = true;
            }
            if (monsterController.monsterNum == 7)
            {
                GameController.Monster7Found = true;
            }
            if (monsterController.monsterNum == 8)
            {
                GameController.Monster8Found = true;
            }
            if (monsterController.monsterNum == 9)
            {
                GameController.Monster9Found = true;
            }
            if (monsterController.monsterNum == 10)
            {
                GameController.Monster10Found = true;
            }
            if (monsterController.monsterNum == 11)
            {
                GameController.Monster11Found = true;
            }
            if (monsterController.monsterNum == 12)
            {
                GameController.Monster12Found = true;
            }
            if (monsterController.monsterNum == 13)
            {
                GameController.Monster13Found = true;
            }
            if (monsterController.monsterNum == 14)
            {
                GameController.Monster14Found = true;
            }
            if (monsterController.monsterNum == 15)
            {
                GameController.Monster15Found = true;
            }
            if (monsterController.monsterNum == 16)
            {
                GameController.Monster16Found = true;
            }
            if (monsterController.monsterNum == 17)
            {
                GameController.Monster17Found = true;
            }
        }
    }
}
