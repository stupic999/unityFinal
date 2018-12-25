using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : MonoBehaviour {

    public GameObject door;
    public GameObject monster1;
    int once;
	
	// Update is called once per frame
	void Update () {
        if (GameController.isPause != true && GameController.bagIsOpen != true)
        {
            if (GameController.GunDone == true && once == 0)
            {
                door.SetActive(false);
                monster1.SetActive(true);
                once++;
            }
        }
	}
}
