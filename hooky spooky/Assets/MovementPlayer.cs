using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float RotatingA =1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.eulerAngles + new Vector3(RotatingA, 0, 0));
        }
    }
}
