using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossController : MonoBehaviour {

    public AudioClip bossAtked;

    AudioSource audioSource;
    MonsterChase monsterChase;
    NavMeshAgent agent;
    EnemyWordShot enemyWordShot;
    public int BossType = 1;
    public float NextType=10;
    public float ChangeType;

    public int Damage = 10;

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
        audioSource = GetComponent<AudioSource>();
        enemyWordShot = GetComponent<EnemyWordShot>();
        agent = GetComponent<NavMeshAgent>();
        emyStat.FullHp();
        monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
        monsterChase = GetComponentInChildren<MonsterChase>();
        monsterChase.foundPlayer = true;
    }

    private void Update()
    {
        if (ChangeType < NextType)
        {
            ChangeType += Time.deltaTime;
        }
        else if(ChangeType>=NextType)
        {
            ChangeType = 0;
            BossType=Random.Range(0, 3);
        }

        if (BossType == 0)
        {
            agent.speed = 3;
            Damage = 20;
            enemyWordShot.NextFire = 2f;
        }
        if (BossType == 1)
        {
            agent.speed = 4;
            Damage = 10;
            enemyWordShot.NextFire = 100f;
        }
        if (BossType == 2)
        {
            agent.speed = 2;
            Damage = 0;
            enemyWordShot.NextFire = 0.3f;
        }
    }

    public void DamageEmy(int damage)
    {
        audioSource.PlayOneShot(bossAtked);
        emyStat.currentHp -= damage;
        if (emyStat.currentHp <= 0)
        {
            GameController.Win = true;
            gameObject.SetActive(false);
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