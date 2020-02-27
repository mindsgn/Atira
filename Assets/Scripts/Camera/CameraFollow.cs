using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float height;
    public float distance;

    public float rotationDamping;
    public float heightDamping;

    private void Update()
    {
        if (!target) {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        } else {
            var wantedRotationAngle = target.eulerAngles.y;
            var wantedHeight = transform.position.y + height;

            var currentRotationAngle = transform.eulerAngles.y;
            var currentHeight = transform.position.y;

            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * heightDamping);

            var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

            transform.position = target.position;
            transform.position -= currentRotation * Vector3.forward * distance;

            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

            transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rotationDamping * Time.deltaTime);
        }
    }
}
