using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class VisionEnemy : MonoBehaviour
{
    public Rigidbody Player;
    

    public UnityEvent PlayerSpotted;
    private bool Found = false;
    public void FoundPlayer()
    {
        if (Found == true)
        {
            PlayerSpotted.Invoke();
        }
    }

    public void OnTriggerEnter(Collider other) 
    {
        if (!other.CompareTag("Player")) 
        {
            
            Debug.Log("found");
            return;
        }

        Found = true;
    }
    public void LookingBehaviore()
    {
        transform.parent.localRotation = Quaternion.Euler(0, 90 * Mathf.Sin(Time.time), 0);
        //enemy.transform.Rotate(0,90*Mathf.Sin(Time.time)*Time.deltaTime,0);
    }
}
