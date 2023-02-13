using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColor : MonoBehaviour
{
    //connect with little guy's game object
    public GameObject littleGuy;
    
    //buttons are set to choose player's color
    public void ColorChanger(string colorName)
    {
        if (colorName == "Green")
        {
            StoreColor.Instance.playerColor = new Color32(166, 255, 138, 255);
            StoreColor.Instance.colorChosenBool = true;     //a color is chosen
            
            //change little guy's color
            littleGuy.GetComponent<SpriteRenderer>().color = new Color32(166, 255, 138, 255);
        }

        else if (colorName == "Yellow")
        {
            StoreColor.Instance.playerColor = new Color32(255, 251, 168, 255);
            StoreColor.Instance.colorChosenBool = true;
            
            littleGuy.GetComponent<SpriteRenderer>().color = new Color32(255, 251, 168, 255);
        }

        else if (colorName == "Purple")
        {
            StoreColor.Instance.playerColor = new Color32(206, 136, 255, 255);
            StoreColor.Instance.colorChosenBool = true;
            
            littleGuy.GetComponent<SpriteRenderer>().color = new Color32(206, 136, 255, 255);
        }

        if (colorName == "Red")
        {
            StoreColor.Instance.playerColor = new Color32(255, 166, 166, 255);
            StoreColor.Instance.colorChosenBool = true;
            
            littleGuy.GetComponent<SpriteRenderer>().color = new Color32(255, 166, 166, 255);
        }

        if (colorName == "Random")                  //get a random color
        {
            byte R = (byte)Random.Range(0, 255);
            byte G = (byte)Random.Range(0, 255);
            byte B = (byte)Random.Range(0, 255);
            StoreColor.Instance.playerColor = new Color32(R, G, B, 255);
            StoreColor.Instance.colorChosenBool = true;
            
            littleGuy.GetComponent<SpriteRenderer>().color = new Color32(R, G, B, 255);
        }
    }
}
