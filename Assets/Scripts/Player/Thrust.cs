using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    public float Speed = 5.0f;


    private void Update()
    {
        var Offset = Vector3.forward * Time.deltaTime * Speed;
        this.transform.Translate(Offset);
    }
}
