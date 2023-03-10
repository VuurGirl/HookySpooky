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
    public bool Follow = false;
   public float enemyMove = 1f;

    private void Start()
    {
      
    }

    void Update()
    {
       

        FollowResponse();
    }

    public void PlayerFoundResponse()
    {
        
        Follow = true;
    }

    public void FollowResponse()
    {
        if (Follow == true)
        {
            
            Vector3 playerFloorPoint = new(player.position.x, 0, player.position.z);
            transform.LookAt(playerFloorPoint);
            gameObject.transform.localPosition += transform.rotation * (new Vector3(0, 0, enemyMove) * Time.deltaTime);

            ;
        }
        else {
            vision.LookingBehaviore();
                }
    }




    }
