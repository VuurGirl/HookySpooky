using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemy : MonoBehaviour
{

 
    public GameObject deathEnemy;
    public BoxCollider Bollet;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Debug.Log("geraakt");
            Instantiate(deathEnemy,transform.localPosition, transform.rotation);
            Destroy(enemy);
        }
    }
}
