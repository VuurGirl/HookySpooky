using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public int killCount= 0;
 
    void Awake()
    {
        Instance = this;

    }
}
