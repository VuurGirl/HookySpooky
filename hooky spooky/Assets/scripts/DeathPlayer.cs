using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
    public GameObject Player;
    public CapsuleCollider enemyColider;
    public GameObject DeathScreen;
    public GameObject Enemy;
    public GameObject playerShooter;
    // Start is called before the first frame update
    void Start()
    {
        DeathScreen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag== "enemy")
        {
            Player.SetActive(false);
            playerShooter.SetActive(false);
            Enemy.SetActive(false);
            DeathScreen.SetActive(true);
        }
    }
}
