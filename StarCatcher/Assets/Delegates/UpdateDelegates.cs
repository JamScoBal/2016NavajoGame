using UnityEngine;
using System.Collections;
using System;

public class UpdateDelegates : MonoBehaviour {

    int Health = 250;
    
    // Actions are a type of delegate. Delegates contain functions just as vars contain data.
    Action DisplayHealth;
    Action KillThePlayer;
    Action EndTheGame;

	// Use this for initialization
	void Start () {
        DisplayHealth = DisplayHealthHandler;
	}

    void DisplayHealthHandler ()
    {
        print("Health is good.");
            DisplayHealth = null;
    }

    void KillThePlayerHandler ()
    {
        Health--;
        if (Health < 0)
        {
            KillThePlayer = null;
            EndTheGame = EndTheGameHandler;
        }
        
    }

    void EndTheGameHandler ()
    {
        print("You didn't even try.");
        EndTheGame = null;
    }

	// Update is called once per frame
	void Update () {
        if(DisplayHealth != null)
        DisplayHealth();

        if (KillThePlayer != null)
            KillThePlayer();

        if (EndTheGame != null)
            EndTheGame();
	}
}
