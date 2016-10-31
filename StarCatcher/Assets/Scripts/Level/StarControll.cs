using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarControll : MonoBehaviour {


    public List<Transform> spawner;
    public List<Transform> stars;

    void SpawnHandler (Transform _t)
    {
        spawner.Add(_t);
    }

    void StarHandler(Transform _t)
    {
        stars.Add(_t);
    }
    // Use this for initialization
    void Start () {
        SpawnStar.SendSpawner += SpawnHandler;
        Star.SendStar += StarHandler;
        StartCoroutine(Spawn());
	}

    private bool canSpawn = true;

    private int starNum;
    private int spawnerNum;

	IEnumerator Spawn ()
    {
        while(canSpawn)
        {
            yield return new WaitForSeconds(1);
            stars[starNum].position = spawner[0].position;
            stars[starNum].GetComponent<MeshRenderer>().enabled = true;
            if(starNum > stars.Count - 1)
            {
                starNum++;
            } else
            {
                starNum = 0;
            }
            if (spawnerNum > stars.Count - 1)
            {
                spawnerNum++;
            }
            else
            {
                spawnerNum = 0;
            }
        }
        
    }
}
