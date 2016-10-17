using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Application.LoadLevel(1);
        }
    }

    void Start ()
    {
        // StaticBars.distance = 6;
        StaticBars.nextSectionPosition = 0;
    }
}
