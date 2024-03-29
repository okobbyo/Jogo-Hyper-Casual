using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public Transform bg1;
    public Transform bg2;

    private float size;


    void Start()
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;
    }

    
    void FixedUpdate() 
    {
       
        if(transform.position.y >= bg2.position.y)
        {
            bg1.position = new Vector3(bg1.position.x, bg2.position.y + size, bg1.position.z);
            SwitchBg();
        }

        if(transform.position.y< bg1.position.y)
        {
            bg2.position = new Vector3(bg2.position.x, bg1.position.y - size, bg2.position.z);
            SwitchBg();
        }
    }


    private void SwitchBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }

}
