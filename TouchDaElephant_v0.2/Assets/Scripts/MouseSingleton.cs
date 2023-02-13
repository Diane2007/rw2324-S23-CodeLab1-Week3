using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSingleton : MonoBehaviour
{
    public static MouseSingleton Instance;

    void Awake()
    {
        if (Instance == null)   //instance not set yet
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
