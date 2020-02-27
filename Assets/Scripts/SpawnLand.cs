using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLand : MonoBehaviour
{
    public GameObject Land;
    public Vector3 Offeset;

    private void Start()
    {
        Instantiate(Land, new Vector3(0,0,0) + Offeset, Quaternion.identity);
        Instantiate(Land, new Vector3(0, 0,1000) + Offeset, Quaternion.identity);
    }

    private void Update()
    {

        var Player = GameObject.FindGameObjectWithTag("Player");

        if (Player)
        {
            var Lands = GameObject.FindGameObjectsWithTag("Land");

            foreach (GameObject respawn in Lands)
            {
                if (respawn.transform.position.z < Player.transform.position.z +1000f) {
                    Destroy(respawn);
                    Instantiate(Land, Player.transform.position + Offeset, Quaternion.identity);
                }
                //Instantiate(, respawn.transform.position, respawn.transform.rotation);
            }
        }else{

        }
    }
}
