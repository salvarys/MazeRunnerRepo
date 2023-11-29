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



    /* void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < maxItems; i++)
        {
            gameManager.Items += 1;
        }

        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);

            Debug.Log("Item collected!");

            gameManager.Items += 1;

        }
    }*/
}