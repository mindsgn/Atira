using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveForward : MonoBehaviour
{
    public float Speed;
    public float Acceleration;

    private void FixedUpdate()
    {
        transform.Translate(transform.forward * Speed * Time.deltaTime, Space.World);
    }
}
