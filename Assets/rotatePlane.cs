using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlane : MonoBehaviour
{
    Vector3 vup = new Vector3( 0.0f, 0, 0.05f );
    Vector3 vdown = new Vector3(0.0f, 0, -0.05f);
    bool up = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.z > 41)
            up = false;
        else if (transform.rotation.eulerAngles.z < 21)
        {
            up = true;
        }
        if (up)
            transform.Rotate(vup);
        else
            transform.Rotate(vdown);
            
    }
}
