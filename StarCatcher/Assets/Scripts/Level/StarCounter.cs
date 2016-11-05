using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarCounter : MonoBehaviour {

    public static int starCount;
    public Text starText;
	
	// Update is called once per frame
	void Update () {
        starText.text = ("X " + starCount);
	}

}
