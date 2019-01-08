using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public static bool Bdone;
    public static bool BagCantClose;

    public GameObject monster1;
    public GameObject bag;

    // Update is called once per frame
    public void monster1In()
    {
            monster1.SetActive(true);
            bag.SetActive(true);
    }
}
