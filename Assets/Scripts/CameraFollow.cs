using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject Player;
    public Vector3 Offset;
    public float Speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Player)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        } else {
            //Transform.Translate(new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z),  Space.World);
            transform.position = Vector3.Lerp(transform.position, Player.transform.position + Offset , Speed);

            transform.LookAt(Player.transform);
        }
    }
}
