using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController myCC;
    private Vector3 tempPos;
    public float speed = 10.0f;
    public float gravity = 1.0f;
    public float jumpSpeed = 1.0f;
    public int jumpCount = 0;
    public int jumpCountMax = 1;

    void Start ()
    {
        myCC = GetComponent<CharacterController>();
    }
	
	
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
        {
            jumpCount++;
            tempPos.y = jumpSpeed;
        }
        if(myCC.isGrounded)
        {
            jumpCount = 0;
        }
        

        tempPos.y -= gravity;
        tempPos.x = speed*Input.GetAxis("Horizontal");
        myCC.Move(tempPos * Time.deltaTime);
	}
}
