using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomPortalShow : MonoBehaviour {

    public GameObject Portal;
	
	// Update is called once per frame
	void Update () {
        if (GameController.FirstRoomPortalDone == true)
        {
            Portal.SetActive(true);
        }
	}
}
