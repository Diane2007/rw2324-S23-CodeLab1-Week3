using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMaster : MonoBehaviour
{
    public static ResetMaster Instance;
    
    //default: not deleting the elephant and giraffe txt files
    public bool resetDataBool = false;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
