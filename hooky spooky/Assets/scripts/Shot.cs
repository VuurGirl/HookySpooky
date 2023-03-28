using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject UsedShots;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fireing();

    }

    public void Fireing()
    { if (Input.GetMouseButtonDown(0) && transform.childCount>1)
        {
            Instantiate(Bullet,transform.position, transform.rotation);
            //transform.GetChild(1).SetParent(UsedShots.transform);
            Destroy(transform.GetChild(1).gameObject);
            // transform.SetParent(usedObjects.transform);
        }
    }
        
} 




