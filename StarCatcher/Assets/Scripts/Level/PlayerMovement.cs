﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController myCC;
    private Vector3 tempPos;
    public float speed = 5.0f;
    public float gravity = 1.0f;
    public float jumpSpeed = 1.0f;
    public int jumpCount = 0;
    public int jumpCountMax = 1;
    public int slideDuration = 100;
    public float slideTime = 0.1f;
    public AudioClip clip;
    private AudioSource source;
   
    void Start ()
    {
        myCC = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
    }
	
	IEnumerator Slide ()
    {
        int durationTemp = slideDuration;
        float speedTemp = speed;

        while (slideDuration > 0)
        {
            speed += speed;
            slideDuration--;
            yield return new WaitForSeconds(slideTime);
        }
        speed = speedTemp;
        slideDuration = durationTemp;
    }


	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
        {
            jumpCount++;
            tempPos.y = jumpSpeed;
            source.Play();
        }
        if(myCC.isGrounded)
        {
            jumpCount = 0;
        }
        
        if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(Slide());
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(Slide());
        }

        tempPos.y -= gravity;
        tempPos.x = speed*Input.GetAxis("Horizontal");
        myCC.Move(tempPos * Time.deltaTime);
	}

  
}
