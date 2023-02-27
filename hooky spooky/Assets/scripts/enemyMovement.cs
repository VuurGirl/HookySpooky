using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{
    public Transform player;
    public Transform enemy;
    public VisionEnemy vision;
    public NavMeshAgent navMeshAgent;

    private void Start()
    {
       // NavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        UpdateState();
    }

    public void PlayerFoundResponse()
    {
        transform.LookAt(player);
        Debug.Log("looking");
    }
    
    public enum StateEnum {  looking , walking , runing , atacking}
    private StateEnum state;
    private void UpdateState()
    {
        switch(state)
        {
            case StateEnum.looking: vision.LookingBehaviore(); break;
        }

    }
    private void PatrolBehaviour()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            //patrolIndex += 1;
           // if (patrolIndex >= patrolPoints.Length)
           // {
            //    patrolIndex = 0;
            //}
            //navMeshAgent.SetDestination(patrolPoints[patrolIndex].transform.position);
        }
    }


    }
