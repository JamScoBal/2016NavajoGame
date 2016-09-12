using UnityEngine;
using System.Collections;

public class PlayerSlide : MonoBehaviour {

    private CharacterController myCC;
    public int slideDuration = 100;
    public float slideTime = 0.01f;

    IEnumerator Slide ()
    {
        int i = 0;

        while (i < slideDuration)
        {
            i++;
            yield return new WaitForSeconds(slideTime);
            print("sliding");

        }
    }

	// Use this for initialization
	void Start ()
    {
        myCC = GetComponent<CharacterController>();
        StartCoroutine(Slide());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
