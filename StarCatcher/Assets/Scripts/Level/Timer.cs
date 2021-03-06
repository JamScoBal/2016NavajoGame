﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public static float myTimer = 180;
    private Text timerText;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        myTimer -= Time.deltaTime;
        string minutes = ((int)myTimer / 60).ToString();
        string seconds = (myTimer % 60).ToString("00");
        timerText.text = minutes + ":" + seconds;

        if(myTimer < 0)
        {
            Application.LoadLevel(2);
        }
	}
}
