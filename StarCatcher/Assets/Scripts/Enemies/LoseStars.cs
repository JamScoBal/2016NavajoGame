using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoseStars : MonoBehaviour {

    public int stolen = 5;
    public AudioClip clip;
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StarCounter.starCount = StarCounter.starCount - stolen;
            source.Play();
        }
    }
}
