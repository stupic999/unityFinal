﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmyBulletController : MonoBehaviour {

    public float bulletSpd = 1f;
    float destroyTime = 2;
    float surviveTime;
    public int damage = 15;

    void Update()
    {
        if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
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
        if (collision.tag != "Emy"&& collision.tag!="EmyWord"  && collision.tag != "Search" && collision.tag!="Boss")
        {
            Destroy(gameObject);
            if (collision.tag == "Player")
            {
                PlayerController playerController = collision.GetComponent<PlayerController>();
                playerController.DamagePlayer(damage);
            }
        }
    }
}