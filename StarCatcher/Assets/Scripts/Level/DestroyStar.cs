using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour
{
    public ParticleSystem Burst;
    public ParticleSystem Flash;
    public Transform star;

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(2.9f);
        Burst.Play();
        Flash.Play();
    }

    void OnCollisionEnter()
    {
        StartCoroutine(Boom());
        StartCoroutine(Die());
        print("Touchdown!");
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}
