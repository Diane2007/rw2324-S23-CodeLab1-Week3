using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColor : MonoBehaviour
{
    public bool colorChosenBool = false;        //default: no color has been chosen
    
    public static StoreColor Instance;
    public Color playerColor = Color.green;  //default player color is green

    void Awake()
    {
        if (Instance == null)               //instance not set yet
        {
            DontDestroyOnLoad(gameObject);  //dont get rid of the game object
            Instance = this;                //set instance to this game object
        }

        else
        {                                   //if instance is already set
            Destroy(gameObject);            //get rid of the game object
        }
    }
}
