using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterWordController : MonoBehaviour {

    public int Damage = 10;
    public GameObject Word;
    public bool Alive = true;
    public int monsterNum;

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

    private void Update()
    {
        if (GameController.isLoadHp == true)
        {
            if (monsterNum == 0)
            {
                emyStat.currentHp = GameController.MonsterTHp;
            }
            else if (monsterNum == 1)
            {
                emyStat.currentHp = GameController.Monster0Hp;
            }
            monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
        }
    }

    public void DamageEmy(int damage)
    {
        emyStat.currentHp -= damage;
        if (emyStat.currentHp <= 0)
        {
            MonsterTuturialDie tutorial = GetComponent<MonsterTuturialDie>();
            if (tutorial != null)
            {
                GameController.FirstRoomPortalDone = true;
                tutorial.PortalShow();
            }
            gameObject.SetActive(false);
            Alive = false;
            Instantiate(Word, transform.position, transform.rotation);
        }
        if (monsterNum == 0)
        {
            GameController.MonsterTHp = emyStat.currentHp;
        }
        else if (monsterNum == 1)
        {
            GameController.Monster0Hp = emyStat.currentHp;
        }
        monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
    }

    void OnTriggerStay(Collider collision)
    {
        if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
        {
            if (collision.tag == "Player")
            {
                PlayerController player = collision.GetComponent<PlayerController>();
                player.DamagePlayer(Damage);
            }
        }
    }
}
