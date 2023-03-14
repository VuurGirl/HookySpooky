using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fireing()
    { if (Input.GetMouseButtonDown(0))
        {
            transform.GetChild(0).localPosition += new Vector3(0,1,0);
            Bullet.SetActive(true);
        }
    }
        
} 




