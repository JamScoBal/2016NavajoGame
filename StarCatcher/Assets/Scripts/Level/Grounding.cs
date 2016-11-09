using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Grounding : MonoBehaviour {
    
    private CharacterController cc;
    private float gravity = 1;
    private Vector3 tempP;
    public Transform Player;

	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tempP.y = -gravity;
        cc.Move(tempP * Time.deltaTime);
	}
}
