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
        StaticBars.nextSectionPosition = 0;
    }
}
