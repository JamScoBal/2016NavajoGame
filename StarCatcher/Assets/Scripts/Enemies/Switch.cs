using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public Transform Wolf;
    private float Opposite = -1;

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Wolf.Rotate(0, 180, 0);
            GameObject wolf = GameObject.Find("Wolf");
            EnemyGrounding enemyGrounding = Wolf.GetComponent<EnemyGrounding>();
            enemyGrounding.Speed = enemyGrounding.Speed * -1;
        }
    }
}
