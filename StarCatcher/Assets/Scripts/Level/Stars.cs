using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour {

    public AudioClip clip;
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collider.gameObject.tag == "Player")
        {
            StarCounter.starCount++;
            source.Play();
        }
        
    }
}
