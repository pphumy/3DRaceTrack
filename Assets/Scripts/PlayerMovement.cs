using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public Vector3[] checkPoints;
    public float speed= 1;
    public int targetIndex;
    
    [SerializeField] private DriveMode Mode = DriveMode.Automatically;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = checkPoints[targetIndex];
            if ((transform.position - targetPosition).magnitude > 1)
            {
                MoveTo(targetPosition);
            }
            else
            {
                targetIndex++;
                if (targetIndex >= 4) targetIndex = 0;
            }
        
    }
    void MoveTo(Vector3 target)
    {
        Vector3 position = transform.position;
        Vector3 angles = transform.eulerAngles;
        if (position.x <target.x && target.x-position.x >0.01)
        {
            position.x += speed;
        }
        if (position.x > target.x && position.x - target.x > 0.01)
        {
            position.x -= speed;
        }
        
        if (position.z < target.z && target.z - position.z > 0.01)
        {
            position.z += speed;
        }
        if (position.z > target.z && position.z - target.z > 0.01)
        {
            position.z -= speed;
        }
        transform.position = position;
        if (targetIndex == 1) angles.y = -90;
        if (targetIndex == 2) angles.y = -180;
        if (targetIndex == 3) angles.y = 90;
        if (targetIndex == 0) angles.y = 0;
        transform.eulerAngles = angles;


    }
    void MoveByKeyBoard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
        }
    }
    
}
