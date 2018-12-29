using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : MonoBehaviour {

    public GameObject door;
    public GameObject monster1;
    public GameObject bag;
    int once;

    // Update is called once per frame
    void Update()
    {
        if (GetWords.gotU == true && GameController.GunDone == false && once == 0)
        {
            door.SetActive(false);
            monster1.SetActive(true);
            bag.SetActive(true);
            once++;
        }
    }
}
