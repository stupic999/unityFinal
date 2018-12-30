using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.gameOver==false && player!=null)
        transform.position=(new Vector3(player.transform.position.x, 10f, player.transform.position.z));
	}
}
