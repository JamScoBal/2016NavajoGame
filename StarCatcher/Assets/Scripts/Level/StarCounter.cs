using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarCounter : MonoBehaviour {

    public int starCount = 0;
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = starCount.ToString();
	}
}
