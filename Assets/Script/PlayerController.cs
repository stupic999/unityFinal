using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public Dialogue dialogue;

    // 移动
    Vector3 movement;
    public float moveSpd;
    Rigidbody playerRb;

    // 死了几次
    int dieTime;

    // 玩家被伤害后的无敌
    float invincibleTime;
    bool isInvincible;
    float timeSpentInvincible;
    Renderer playerRender;
    CheckPoint loadCheckPoint;
    

    [System.Serializable]
    public class playerStats
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

    public playerStats playerStat = new playerStats();

    [SerializeField]
    private Hp playerHp;

    void Start()
    {
        playerStat.FullHp();
        playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
        playerRb = GetComponent<Rigidbody>();
        playerRender = GetComponent<Renderer>();
        loadCheckPoint = GameObject.FindGameObjectWithTag("GM").GetComponent<CheckPoint>();
    }

    void FixedUpdate()
    {
        if (GameController.isPause != true && GameController.bagIsOpen != true)
        {
            // 被伤害后的无敌效果
            if (invincibleTime > 0f)
            {
                invincibleTime -= Time.deltaTime;
                isInvincible = true;
            }

            // 被伤害后的闪烁
            if (isInvincible == true)
            {
                timeSpentInvincible += Time.deltaTime;

                if (timeSpentInvincible < 1f)
                {
                    float remainder = timeSpentInvincible % 0.2f;
                    playerRender.enabled = remainder > 0.15f;
                }
                else
                {
                    playerRender.enabled = true;
                    isInvincible = false;
                    timeSpentInvincible = 0;
                }
            }
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            Move(h, v);
        }
    }

    public void Move(float h,float v)
    {
        movement.Set(h, 0, v);

        movement = movement.normalized * moveSpd * Time.deltaTime;

        playerRb.MovePosition(transform.position + movement);
    }

    public void DamagePlayer(int damage)
    {
        if (invincibleTime <= 0)
        {
            playerStat.currentHp -= damage;
            if (playerStat.currentHp <= 0)
            {
                playerStat.FullHp();
                transform.position = loadCheckPoint.lastCheckPoint;
                dieTime++;
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

                if (dieTime >= 3)
                {
                    GameController.gameOver = true;
                }
            }
            playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
            invincibleTime = 1f;
        }
    }

    public void HealPlayer(int heal)
    {
        playerStat.currentHp += heal;
        playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
    }     
}