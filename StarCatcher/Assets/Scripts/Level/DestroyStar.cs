using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour
{
    public ParticleSystem Burst;
    public ParticleSystem Flash;
    public Transform star;
    public Renderer off;
    public AudioClip poof;
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(2.7f);
        Burst.Play();
        Flash.Play();
        source.Play();
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
}
