using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Relationship : MonoBehaviour
{
    //connect with other scripts
    public GameManager gameManager;
    
    //bools to increase relationship per touch
    private bool eleTouched = false;
    private bool girTouched = false;
    
    //connect with the heart game object
    public GameObject heart;        //the heart sprite that will spawn
    private GameObject newHeart;    //the instantiated heart
    
    //get the position of the mouse
    private Vector2 mousePos;

    private void OnCollisionEnter2D(Collision2D animalTouch)
    {
        if (animalTouch.gameObject.CompareTag("Elephant") && (eleTouched == false))
        {
            eleTouched = true;  //elephant is now touched and should not keep adding points to it
            gameManager.EleLike++;
            SpawnHeart();       //spawns a heart
            Debug.Log("Ele disabled. Like value is " + gameManager.EleLike);

            StartCoroutine(EnableIncrease());
        }

        if (animalTouch.gameObject.CompareTag("Giraffe") && (girTouched == false))
        {
            girTouched = true;
            gameManager.GirLike++;
            SpawnHeart();       //spawns a heart
            Debug.Log("Gir disabled. Like value is " + gameManager.GirLike);

            StartCoroutine(EnableIncrease());

        }
    }

    IEnumerator EnableIncrease()
    {
        //wait for 2 seconds before enabling relationship increase again
        if (eleTouched == true)
        {
            yield return new WaitForSeconds(2);
            eleTouched = false;
            Debug.Log("Ele enabled.");
        }
        if (girTouched == true)
        {
            yield return new WaitForSeconds(2);
            girTouched = false;
            Debug.Log("Gir enabled.");
        }
    }

    void Update()
    {
        //get the updated mouse positon
        mousePos = transform.position;
    }

    public void SpawnHeart()
    {
        
        //spawns only when relationship with animals increases
        if (eleTouched == true || girTouched == true)
        {
            newHeart = Instantiate<GameObject>(heart);
            //set the new heart's position
            newHeart.GetComponent<Transform>().position =
                new Vector2(mousePos.x, (mousePos.y + 2f));

        }

        //destroys after 1 sec
        Destroy(newHeart, 1);
    }

}
