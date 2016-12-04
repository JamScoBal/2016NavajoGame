using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collider.gameObject.tag == "Player")
        {
            StarCounter.starCount++;
        }
        
    }
}
