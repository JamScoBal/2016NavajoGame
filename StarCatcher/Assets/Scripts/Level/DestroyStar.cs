using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour
{
    public ParticleSystem Burst;
    public ParticleSystem Flash;
    public Transform star;
    public Renderer off;

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(2.7f);
        Burst.Play();
        Flash.Play();
    }

    void OnCollisionEnter()
    {
        StartCoroutine(Boom());
        StartCoroutine(Die());
        StartCoroutine(Invisible());
        print("Touchdown!");
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
