using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour {

	// Update is called once per frame
	void FixedUpdate () {
        // 玩家旋转3D
        if (GameController.isPause != true && GameController.bagIsOpen != true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 playerToMouse = hit.point - transform.position;
                playerToMouse.y = 0;

                Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

                transform.rotation = newRotation;
            }
        }
    }
}
