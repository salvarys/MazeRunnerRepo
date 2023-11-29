using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameBehavior : MonoBehaviour
{
    public string labelText = "Collect all to win!!!";
    public int maxItems = 1;
    public bool showWinScreen = false;

    public PlayerBehavior player;
    public TMP_Text itemsText;

    public void Items()
    {
        Debug.LogFormat("Items: { ", player._itemsCollected, "}");
    }

    void Update()
    {
        /*
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " +
            _itemsCollected);

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height -
            50, 300, 50), labelText);
        */

        itemsText.text = "Items Collected: " + player._itemsCollected;

        if (player._itemsCollected == maxItems)
        {
            labelText = "You've found all the items!";
            showWinScreen = true;
            Time.timeScale = 0f;
        }
        else
        {
            labelText = "Item found, only" + (maxItems -
                player._itemsCollected) + " more to go!";
        }
        /* 
         //Error checking 

            if (player != null && maxItems > 0)
            {
                if (player._itemsCollected == maxItems)
                 {
                    labelText = "You've found all the items!";
                    showWinScreen = true;
                    Time.timeScale = 0f;
                 }
                else if (player._itemsCollected < maxItems)
                {
                    labelText = "Item found, only " + (maxItems - player._itemsCollected) + " more to go!";
                }
                else
                {
                  // Handle the case where _itemsCollected exceeds maxItems
                     labelText = "Error: _itemsCollected exceeds maxItems!";
                }
               
                 else
                 {
                  // Handle the case where player is null or maxItems is not a valid value
                    labelText = "Error: Invalid player or maxItems value!";
            }  

        // While Loop demo 

           while (player._itemsCollected < maxItems)
            {
                labelText = "Item found, only " + (maxItems - player._itemsCollected) + " more to go!";
            }

            labelText = "You've found all the items!";
            showWinScreen = true;
            Time.timeScale = 0f;
         */

        if (showWinScreen)
        {

            if (GUI.Button(new Rect(Screen.width / 2 - 100,
               Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {


                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }
        }
    }
}