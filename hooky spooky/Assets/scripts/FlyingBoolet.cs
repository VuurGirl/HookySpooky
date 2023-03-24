using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBoolet : MonoBehaviour
{
   public Rigidbody BulletBody;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletBody.AddForce(transform.forward* speed);
       //transform.position += new Vector3(0, 0, -5) * Time.deltaTime;

        //if (transform.GetChild(0).position>new Vector3(10,10,10)
        //{

        //}S
    }
}
