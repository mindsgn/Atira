using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //accelDir -= 1;
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //accelDir += 1;
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), 0.1f);
        }
    }
}
