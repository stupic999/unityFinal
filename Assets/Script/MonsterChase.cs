using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterChase : MonoBehaviour
{
    public GameObject destinationTarget;
    NavMeshAgent agent;
    public bool foundPlayer;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (GameController.isPause != true && GameController.bagIsOpen != true && GameController.gameOver != true && destinationTarget != null && foundPlayer == true)
        {
            agent.enabled = true;
            agent.destination = destinationTarget.transform.position;
        }
        else
        {
            agent.enabled = false;
        }
    }
}