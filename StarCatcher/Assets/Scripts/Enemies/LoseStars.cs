using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoseStars : MonoBehaviour {

    public int stolen = 5;

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StarCounter.starCount = StarCounter.starCount - stolen;
        }
    }
}
