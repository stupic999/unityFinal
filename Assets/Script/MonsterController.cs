using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    [System.Serializable]
    public class monsterStats
    {
        public int maxHp = 100;
        int _currentHp;
        public int currentHp
        {
            get { return _currentHp; }
            set { _currentHp = Mathf.Clamp(value, 0, maxHp); }
        }

        public void FullHp()
        {
            currentHp = maxHp;
        }
    }

    public monsterStats emyStat = new monsterStats();

    [SerializeField]
    private Hp monsterHp;

    void Start()
    {
        emyStat.FullHp();
        monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
    }     

    public void DamageEmy(int damage)
    {
        emyStat.currentHp -= damage;
        if (emyStat.currentHp<= 0)
        {
            Destroy(gameObject);
        }
        monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
    }
}
