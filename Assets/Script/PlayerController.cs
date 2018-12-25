using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

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
    }

    void FixedUpdate()
    {
        // 移动
        if (GameController.isPause != true && GameController.bagIsOpen != true)
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(0, 0, 0.1f, Space.World);

            if (Input.GetKey(KeyCode.S))
                transform.Translate(0, 0, -0.1f, Space.World);

            if (Input.GetKey(KeyCode.A))
                transform.Translate(-0.1f, 0, 0, Space.World);

            if (Input.GetKey(KeyCode.D))
                transform.Translate(0.1f, 0, 0, Space.World);
        }
    }

    public void DamagePlayer(int damage)
    {
        playerStat.currentHp -= damage;
        if (playerStat.currentHp <= 0)
        {
            Destroy(gameObject);
        }
        playerHp.SetHealth(playerStat.currentHp, playerStat.maxHp);
    }
}
