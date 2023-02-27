using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float Rotating =1f;
    public float move = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(new Vector3(0, Rotating, 0)*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(new Vector3(0, -Rotating, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W)) 
        {
            gameObject.transform.localPosition+= transform.rotation * (new Vector3(0, 0, move) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.localPosition -= transform.rotation * (new Vector3(0, 0, move) * Time.deltaTime);
        }
    }

}
