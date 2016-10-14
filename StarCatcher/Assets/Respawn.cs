using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {

    
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Application.LoadLevel(0);
        }
    }

    void Start ()
    {
        StaticBars.distance = StaticBars.newLevelPosition;
    }
}
