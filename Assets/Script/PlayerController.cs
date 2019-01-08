using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public Dialogue dialogue;

    public Animator playerAnim;
    
    // 移动
    Vector3 movement;
    public float moveSpd;
    Rigidbody playerRb;

    // 玩家被伤害后的无敌
    public float invincibleTime;
    public  bool isInvincible;
    float timeSpentInvincible;
    Renderer playerRender;    

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
    private PlayerHp playerHp;

    public AudioClip PlayerAtkedSound;
    public GameObject PlayerWalkSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerStat.FullHp();
        playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
        playerRb = GetComponent<Rigidbody>();
        playerRender = GetComponentInChildren<SpriteRenderer>();
    }

    void FixedUpdate()
    {     
        // 作弊
        if (Input.GetKey(KeyCode.F4))
        {
            playerStat.maxHp = 10000;
            playerStat.FullHp();
            playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
        }

        if (GameController.isLoadHp == true)
        {
            playerStat.currentHp = GameController.playerHp;
            playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
        }

        if (GameController.isPause != true && GameController.isMenu != true && GameController.bagIsOpen != true)
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
        else
        {
            PlayerWalkSound.SetActive(false);
        }
    }

    public void Move(float h, float v)
    {
        movement.Set(h, 0, v);

        movement = movement.normalized * moveSpd * Time.deltaTime;

        playerRb.MovePosition(transform.position + movement);

        if (h != 0 || v != 0)
        {
            playerAnim.SetBool("isMove", true);
            PlayerWalkSound.SetActive(true);
        }
        else
        {
            playerAnim.SetBool("isMove", false);
            PlayerWalkSound.SetActive(false);
        }            
    }

    public void DamagePlayer(int damage)
    {
        if (invincibleTime <= 0)
        {
            audioSource.PlayOneShot(PlayerAtkedSound);
            playerStat.currentHp -= damage;
            if (playerStat.currentHp <= 0)
            {
                audioController.PlayerDie = true;
                GameController.dieTime++;
                if (GameController.dieTime >= 3)
                {
                    GameController.gameOver = true;
                }
                else
                {
                    playerStat.FullHp();
                    transform.position = GameController.lastCheckPoint;
                    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                }                
            }            
            playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
            GameController.playerHp = playerStat.currentHp;
            invincibleTime = 1f;
        }
    }

    public void HealPlayer(int heal)
    {
        playerStat.currentHp += heal;
        playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
    }     
}