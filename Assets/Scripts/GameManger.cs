using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private float score = 0f;
    private float lives = 0f;
   
    GameObject player;
   
    void Start()
    {

        //** Uncomment the Debug Log below and add the appropriate varible names to show the starting score and lives in the console **//
        //** Debug.Log("Score: " +  + "\n" + "Lives: " + ); 
        
        
        player = GameObject.Find("Player");
        
    }

   
    void Update()
    {

    }

    public void UpdateLives(int value)
    {
        //** Uncomment the line below and add the appropiate variable name for lives **//
        // changeToVariableName += value;

        //** Uncomment the if statement below and fix the comments
       /* Delete this line when if statement is fixed
            // add the appropriate variable name into the if statement for lives
            if (    < 1)
                {
                    // Create a Debug Log below that displays "Game Over" in the console
                    

                    // Set the variable for lives equal to 0 
                    
                    
                }
        */ //Delete this line when if statement is fixed

        //** Uncomment the line below after adding the appropriate variable name in the Debug Log
        //Debug.Log("Lives: " + );
    }

    public void AddScore(int value)
    {
        //** Uncomment the line below and add the appropiate variable name for score **//
        //changeToVariableName += value;
        
        //** Uncomment the line below after adding the appropriate variable name in the Debug Log **//
        //Debug.Log("Score: " + );
    } 
}
