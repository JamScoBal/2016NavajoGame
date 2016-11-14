using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class EnemyGrounding : MonoBehaviour {
    
    private CharacterController cc;
    public float gravity = 2;
    public float MySpeed = 2;
    private Vector3 tempP;
    public Transform Front;
    public Transform Back;

    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tempP.y = -gravity;
        cc.Move(tempP * Time.deltaTime);

        if (Front.GetComponent<Collider>())
        {
            tempP.x = Mathf.Abs(MySpeed);
        }
        else if(Back.GetComponent<Collider>())
        {
            tempP.x = Mathf.Abs(MySpeed) * -1;
        }
	}
}
