using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{

    public AudioClip AtkedSound;
    public AudioClip AtkSound;
    AudioSource audioSource;
    public bool Alive = true;
    public int monsterNum;
    MonsterSearch monsterSearch;

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
        emyStat.FullHp();
        monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
        monsterSearch = GetComponentInParent<MonsterSearch>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (GameController.isLoadHp == true)
        {
            if (monsterNum == 1)
            {
                emyStat.currentHp = GameController.Monster1Hp;
            }
            else if (monsterNum == 2)
            {
                emyStat.currentHp = GameController.Monster2Hp;
            }
            else if (monsterNum == 3)
            {
                emyStat.currentHp = GameController.Monster3Hp;
            }
            else if (monsterNum == 4)
            {
                emyStat.currentHp = GameController.Monster4Hp;
            }
            else if (monsterNum == 5)
            {
                emyStat.currentHp = GameController.Monster5Hp;
            }
            else if (monsterNum == 6)
            {
                emyStat.currentHp = GameController.Monster6Hp;
            }
            else if (monsterNum == 7)
            {
                emyStat.currentHp = GameController.Monster7Hp;
            }
            else if (monsterNum == 8)
            {
                emyStat.currentHp = GameController.Monster8Hp;
            }
            else if (monsterNum == 9)
            {
                emyStat.currentHp = GameController.Monster9Hp;
            }
            else if (monsterNum == 10)
            {
                emyStat.currentHp = GameController.Monster10Hp;
            }
            else if (monsterNum == 11)
            {
                emyStat.currentHp = GameController.Monster11Hp;
            }
            else if (monsterNum == 12)
            {
                emyStat.currentHp = GameController.Monster12Hp;
            }
            else if (monsterNum == 13)
            {
                emyStat.currentHp = GameController.Monster13Hp;
            }
            else if (monsterNum == 14)
            {
                emyStat.currentHp = GameController.Monster14Hp;
            }
            else if (monsterNum == 15)
            {
                emyStat.currentHp = GameController.Monster15Hp;
            }
            else if (monsterNum == 16)
            {
                emyStat.currentHp = GameController.Monster16Hp;
            }
            else if (monsterNum == 17)
            {
                emyStat.currentHp = GameController.Monster17Hp;
            }
            monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
        }
    }

    public void DamageEmy(int damage)
    {
        audioSource.PlayOneShot(AtkedSound);
        emyStat.currentHp -= damage;
        if (emyStat.currentHp<= 0)
        {
            audioController.MonsterDie = true;
            gameObject.SetActive(false);
            Alive = false;
            monsterSearch.monsterDie = true;
            GameController.monstersDie++;            
        }
        monsterHp.SetHealth(emyStat.currentHp, emyStat.maxHp);
        if (monsterNum == 1)
        {
            GameController.Monster1Hp = emyStat.currentHp;
        }
        else if (monsterNum == 2)
        {
            GameController.Monster2Hp = emyStat.currentHp;
        }
        else if (monsterNum == 3)
        {
            GameController.Monster3Hp = emyStat.currentHp;
        }
        else if (monsterNum == 4)
        {
            GameController.Monster4Hp = emyStat.currentHp;
        }
        else if (monsterNum == 5)
        {
            GameController.Monster5Hp = emyStat.currentHp;
        }
        else if (monsterNum == 6)
        {
            GameController.Monster6Hp = emyStat.currentHp;
        }
        else if (monsterNum == 7)
        {
            GameController.Monster7Hp = emyStat.currentHp;
        }
        else if (monsterNum == 8)
        {
            GameController.Monster8Hp = emyStat.currentHp;
        }
        else if (monsterNum == 9)
        {
            GameController.Monster9Hp = emyStat.currentHp;
        }
        else if (monsterNum == 10)
        {
            GameController.Monster10Hp = emyStat.currentHp;
        }
        else if (monsterNum == 11)
        {
            GameController.Monster11Hp = emyStat.currentHp;
        }
        else if (monsterNum == 12)
        {
            GameController.Monster12Hp = emyStat.currentHp;
        }
        else if (monsterNum == 13)
        {
            GameController.Monster13Hp = emyStat.currentHp;
        }
        else if (monsterNum == 14)
        {
            GameController.Monster14Hp = emyStat.currentHp;
        }
        else if (monsterNum == 15)
        {
            GameController.Monster15Hp = emyStat.currentHp;
        }
        else if (monsterNum == 16)
        {
            GameController.Monster16Hp = emyStat.currentHp;
        }
        else if (monsterNum == 17)
        {
            GameController.Monster17Hp = emyStat.currentHp;
        }        
    }

    void OnTriggerStay(Collider collision)
    {
        if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
        {
            if (collision.tag == "Player")
            {
                PlayerController playerController = collision.GetComponent<PlayerController>();
                if (playerController.isInvincible == false)
                {
                    audioSource.PlayOneShot(AtkSound);
                    playerController.DamagePlayer(Damage);
                }
            }
        }
    }
}
