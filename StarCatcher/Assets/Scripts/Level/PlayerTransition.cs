using UnityEngine;
using System.Collections;

public class PlayerTransition : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetInteger("Change", 1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetInteger("Change", 1);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetInteger("Change", 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetInteger("Change", 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetInteger("Change", 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetInteger("Change", 1);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetInteger("Change", 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetInteger("Change", 0);
        }
            if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("Change", 2);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetInteger("Change", 0);
        }
    }
}
