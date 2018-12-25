using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {



    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(666);
        if (collision.tag == "Player")
        {
                Debug.Log("Hit monster");
        }

    }
}
