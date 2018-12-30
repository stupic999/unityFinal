using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterChase : MonoBehaviour
{
    public GameObject destinationTarget;
    public NavMeshAgent agent;
    void Update()
    {
        if (GameController.isPause != true && GameController.bagIsOpen != true && GameController.gameOver != true && destinationTarget!=null)
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