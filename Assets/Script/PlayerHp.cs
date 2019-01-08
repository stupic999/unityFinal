using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHp : MonoBehaviour {

    [SerializeField]
    private Image hpPic;

    public void SetHealth(int currentHp, int maxHp)
    {
        float value = (float)currentHp / maxHp;
        hpPic.fillAmount = value;
    }
}