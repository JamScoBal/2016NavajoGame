using UnityEngine;
using System.Collections;

public class FlipPlayer : MonoBehaviour {

    public bool forward = true;
    public Transform characterControl;

    void FlipCharacter (bool _b)
    {
        characterControl.Rotate(0, 180, 0);
        forward = _b;
    }
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.RightArrow) && forward)
        {
            FlipCharacter(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !forward)
        {
            FlipCharacter(true);
        }
    }
}
