using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
    public GameObject Player;
   
    public GameObject DeathScreen;
    
    public GameObject playerShooter;
    
    void Start()
    {
        DeathScreen.SetActive(false);

    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Player.SetActive(false);
            playerShooter.SetActive(false);
            DeathEnemy enemy = other.gameObject.GetComponent<DeathEnemy>();
            enemy.Death();
            DeathScreen.SetActive(true);
        }
    }
}
