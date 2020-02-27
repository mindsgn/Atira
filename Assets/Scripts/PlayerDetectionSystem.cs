using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionSystem : MonoBehaviour
{
    public GameObject Explosion;
    GameManger Manager;

    private void Start()
    {
        Manager = new GameManger();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy"  || other.tag == "Bullet") {
            //Destroy(gameObject);
            Manager.GameOver();
        }
    }
}
