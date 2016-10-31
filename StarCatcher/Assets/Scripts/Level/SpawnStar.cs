using UnityEngine;
using System.Collections;
using System;

public class SpawnStar : MonoBehaviour {

    public static Action<Transform> SendSpawner;

	// Use this for initialization
	void Start () {
        SendSpawner(transform);
	}

}
