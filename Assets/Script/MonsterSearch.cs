using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSearch : MonoBehaviour {

    MonsterChase monsterChase;

    private void Start()
    {
        monsterChase= GetComponentInChildren<MonsterChase>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        monsterChase.foundPlayer = true;
    }
}
