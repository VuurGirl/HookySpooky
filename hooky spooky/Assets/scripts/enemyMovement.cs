using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public Transform enemy;
    public VisionEnemy vision;
    public bool follow = false;
   public float enemyMove = 1f;
    public GameObject walkingEnemy;
    public GameObject defoldEnemy;

    private void Start()
    {
        walkingEnemy.SetActive(false);
    }

    void Update()
    {
       

        FollowResponse();
    }

    public void PlayerFoundResponse()
    {
        
        follow = true;
    }

    public void FollowResponse()
    {
        if (follow == true)
        {
            
            Vector3 playerFloorPoint = new(player.position.x, 0, player.position.z);
            transform.LookAt(playerFloorPoint);
            gameObject.transform.localPosition += transform.rotation * (new Vector3(0, 0, enemyMove) * Time.deltaTime);
            walkingEnemy.SetActive(true);
            defoldEnemy.SetActive(false);

        }
        else 
        {
            vision.LookingBehaviore();
        }
    }
}
