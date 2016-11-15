using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class EnemyGrounding : MonoBehaviour {
    
    private CharacterController cc;
    public float gravity = 2;
    private Vector3 tempP;
    public float Speed = 2.0f;

    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tempP.y = -gravity;
        cc.Move(tempP * Time.deltaTime);

        tempP.x = Speed;
    }
}
