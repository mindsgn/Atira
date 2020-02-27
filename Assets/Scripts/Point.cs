using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject vfxFirework; 

    private void OnTriggerEnter(Collider other)
    {
        var FireWork = Instantiate(vfxFirework, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);        
    }
}
