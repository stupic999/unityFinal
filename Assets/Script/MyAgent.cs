using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyAgent : MonoBehaviour
{
    public GameObject destinationTarget;
    public NavMeshAgent agent;
    void Update()
    {
        if (GameController.isPause != true && GameController.bagIsOpen != true)
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