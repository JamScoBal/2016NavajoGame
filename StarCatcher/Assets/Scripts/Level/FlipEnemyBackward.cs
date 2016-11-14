using UnityEngine;
using System.Collections;

public class FlipEnemyBackward : MonoBehaviour {

    public Transform characterControl;
    public bool forward = true;

    void FlipCharacter(bool _b)
    {
        characterControl.Rotate(0, 180, 0);
        forward = _b;
    }

    // Update is called once per frame
    void OnTiggerEnter(Collider other)
    {
        print("triggered");
        if (other.gameObject.tag == "Player" && !forward)
        {
            FlipCharacter(true);
        }
    }
}
