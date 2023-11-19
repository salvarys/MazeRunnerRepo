using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameBehavior").GetComponent<GameBehavior>();
    }

    /*
    void OnCollisionEnter(Collision collision)
    {
        //
        if (collision.gameObject.name == "Player")
        {  
            Debug.Log("Item collected!");

            gameManager._itemsCollected += 1;


        }
    }
    */
}
