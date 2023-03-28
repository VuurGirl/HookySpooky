using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemy : MonoBehaviour
{

  
    public GameObject deathEnemy;
    public BoxCollider Bollet;
    public GameObject enemy;
    public float killedCount =0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
 
    }
    public void Death()
    {
        Debug.Log("jammer joh");
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet")) 
        {
            Debug.Log("geraakt");
            Instantiate(deathEnemy,transform.localPosition, transform.rotation);
            ScoreManager.Instance.killCount++;
            Destroy(gameObject);
        }
    }
}
