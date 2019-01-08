using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public GameObject Menu;
    public static bool MenuOpen;

    private void Update()
    {
        if (GameController.bagIsOpen == false && GameController.isPause == false || GameController.isMenu==true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                MenuOpen = !MenuOpen;
            }
        }

        if (MenuOpen == true)
        {
            GameController.isMenu = true;
            Menu.SetActive(true);
        }
        else
        {
            GameController.isMenu = false;
            Menu.SetActive(false);
        }
    }


}
