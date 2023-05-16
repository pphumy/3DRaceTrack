using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private float speed = 1;
    [SerializeField] private DriveMode Mode = DriveMode.Automatically;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mode == DriveMode.Automatically) MoveTo();
        if (Mode == DriveMode.Manually) MoveByKeyBoard();
        
    }
    void MoveTo()
    {
        Vector3 position = transform.position;
        Vector3 angles = transform.eulerAngles;



        if (position.z > 343)
        {
            angles.y = -90;
            position.x += -speed*Time.deltaTime;
            transform.eulerAngles = angles;
            transform.position = position;
        }
        if (position.x > 545)
        {
            angles.y = 0;


            position.z += speed*Time.deltaTime;
            transform.position = position;
            transform.eulerAngles = angles;
        }

        if (position.z < 275)
        {
            angles.y = 90;
            position.x += speed * Time.deltaTime;
            transform.eulerAngles = angles;
            transform.position = position;
        }
        if (position.x < 499)
        {
            angles.y = 180;
            position.z += -speed * Time.deltaTime;
            transform.eulerAngles = angles;
            transform.position = position;


        }
    }
    void MoveByKeyBoard()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos += v * transform.forward * speed * Time.deltaTime;
        pos.y = 0.4f;
        transform.position = pos;
        Vector3 alpha = transform.eulerAngles;
        alpha.y += h * speed * Time.deltaTime*5f;
        transform.eulerAngles = alpha;
    }
}
