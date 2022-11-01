using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    float GG = 0.01f;
    float X, Y, Z;
    // Start is called before the first frame update
    void Start()
    {
        print(transform.position);

        transform.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        X = transform.position.x;
        Y = transform.position.y;
        Z = transform.position.z;

        if (Input.GetKey(KeyCode.W))
        {
            //print("W");

            transform.position = new Vector3(X, Y + GG, Z);
        }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(X, Y - GG, Z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(X - GG, Y, Z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(X + GG, Y, Z);
            }

        
    }
}
