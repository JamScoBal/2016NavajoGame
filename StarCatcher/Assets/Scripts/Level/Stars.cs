using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour {

    private StarCounter starCount;

	// Use this for initialization
	void Awake ()
    {
        starCount = GameObject.Find("StarCounter").GetComponent<StarCounter>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
            starCount.starCount++;
        gameObject.SetActive(false);
	}
}
