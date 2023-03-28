using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScreens : MonoBehaviour
{ 
   
    public GameObject Screen1;
    public GameObject Screen2;
    public GameObject Screen3;
    public GameObject Screen4;
    public GameObject Screen5;
    public GameObject Screen6;
    public GameObject Screen7;
    public GameObject Screen8;
    public GameObject Screen9;
 
    void Start()
    {
        Screen1.SetActive(true);
        Screen2.SetActive(false); 
        Screen3.SetActive(false); 
        Screen4.SetActive(false); 
        Screen5.SetActive(false); 
        Screen6.SetActive(false); 
        Screen7.SetActive(false);
        Screen8.SetActive(false); 
        Screen9.SetActive(false); 
        
    }

 
    void Update()
    {
    if (ScoreManager.Instance.killCount == 1)
        {
            Screen1.SetActive(false);
            Screen4.SetActive(true);
        }
   
     if (ScoreManager.Instance.killCount == 2)
        {
            Screen4.SetActive(false);
            Screen6.SetActive(true);
        }
        if (ScoreManager.Instance.killCount == 3)
        {
            Screen6.SetActive(false);
            Screen9.SetActive(true);
        }
        if (ScoreManager.Instance.killCount == 5)
        {
            Screen9.SetActive(false);
            Screen1.SetActive(true);
        }
    }

}    
    


