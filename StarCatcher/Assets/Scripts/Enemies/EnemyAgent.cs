using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

    public NavMeshAgent myAgent;
    public Transform Player;
	
    void Start ()
    {
        myAgent.GetComponent<NavMeshAgent>();
    }

	// Update is called once per frame
	void Update () {
        myAgent.destination = Player.position;
	}
}
