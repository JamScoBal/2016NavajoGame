using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour
{
    public ParticleSystem Burst;
    public ParticleSystem Flash;
    public Transform star;
    public Renderer off;
    public AudioSource source;
    public AudioClip clip1;
    public AudioSource clip2;

    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(2.7f);
        Burst.Play();
        Flash.Play();
        source.PlayOneShot(clip1);
    }

    void OnCollisionEnter()
    {
        StartCoroutine(Boom());
        StartCoroutine(Die());
        StartCoroutine(Invisible());
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    IEnumerator Invisible()
    {
        yield return new WaitForSeconds(2.7f);
        off.enabled = false;
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

            clip2.Play();
        }
    }
}
