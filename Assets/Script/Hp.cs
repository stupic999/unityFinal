using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour {

    [SerializeField]
    private RectTransform healthbarRect;
    [SerializeField]
    private Text healthbarText;

    public void SetHealth(int currentHp,int maxHp)
    {
        float value = (float)currentHp / maxHp;

        healthbarRect.localScale = new Vector3(value, healthbarRect.localScale.y, healthbarRect.localScale.z);
        healthbarText.text = currentHp + "/" + maxHp+"HP";
    }
}