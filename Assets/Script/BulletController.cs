using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpd = 1f;
    float destroyTime=2;
    float surviveTime;
    public int damage = 10;

    void Update () {
        if (GameController.isPause != true && GameController.bagIsOpen!=true)
        {
            surviveTime += Time.deltaTime;

            transform.Translate(Vector3.forward * Time.deltaTime * bulletSpd, Space.Self);  

            if (surviveTime >= destroyTime)
            {
                Destroy(gameObject);
            }
        }
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag != "Player")
        {
            Destroy(gameObject);
            if (collision.tag == "Emy")
            {
                MonsterController emy = collision.GetComponent<MonsterController>();
                emy.DamageEmy(damage);
            }
            else if (collision.tag == "EmyWord")
            {
                MonsterWordController emy = collision.GetComponent<MonsterWordController>();
                emy.DamageEmy(damage);
            }
        }
    }
}
