using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;
        Vector3 angles = transform.eulerAngles;



        if (position.z > 343)
        {
            angles.y = -90;
            position.x += -speed;
            transform.eulerAngles = angles;
            transform.position = position;
        }
        if (position.x > 545)
        {
            angles.y = 0;

       
            position.z += speed;
            transform.position = position;
            transform.eulerAngles = angles;
        }

        if (position.z < 275)
        {
            angles.y = 90;
            position.x += speed;
            transform.eulerAngles = angles;
            transform.position = position;
        }
        if (position.x < 499)
        {
            angles.y = 180;
            position.z += -speed;
            transform.eulerAngles = angles;
            transform.position = position;


        }
    }
}
