using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    
    void FixedUpdate() 
    {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);
    }
}
