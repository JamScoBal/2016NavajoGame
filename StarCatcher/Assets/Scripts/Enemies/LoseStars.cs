using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoseStars : MonoBehaviour {

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StarCounter.starCount--;
        }
    }
}
