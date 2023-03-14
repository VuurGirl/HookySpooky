using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterPlayer : MonoBehaviour
{

    public GameObject geweer;
    
    public float horizontalSpeed = 2.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GunRotation();
    }

    public void GunRotation()
    {
        float mouseX = horizontalSpeed * Input.GetAxis("Mouse X") ;
        mouseX = Mathf.Clamp(mouseX, -90, 90);

        transform.Rotate(0, mouseX, 0);

    }


}
