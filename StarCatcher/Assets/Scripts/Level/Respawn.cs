using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    public AudioSource source;
    
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Dead());
            source.Play();
        }
    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(0.3f);
        Application.LoadLevel(1);
    }

    void Start ()
    {
        source = GetComponent<AudioSource>();
        StaticBars.nextSectionPosition = 0;
    }
}
