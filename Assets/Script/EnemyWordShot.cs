 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWordShot : MonoBehaviour {

    public float NextFire = 2f;
    public float FireCD;
    public GameObject enemyBullet;
    public Transform shotSpawn;
    MonsterChase monsterChase;

    private void Start()
    {
        monsterChase = GetComponent<MonsterChase>();
    }

    void Update()
    {
        if (shotSpawn != null && monsterChase!=null && monsterChase.foundPlayer==true)
        {
            if (FireCD < NextFire)
                FireCD += Time.deltaTime;

            if (FireCD >= NextFire)
            {
                Shot();
                FireCD = 0;
            }
        }
    }

    void Shot()
    {
        Instantiate(enemyBullet, shotSpawn.transform.position, shotSpawn.transform.rotation);
       // GetComponent<AudioSource>().Play();
    }
}
