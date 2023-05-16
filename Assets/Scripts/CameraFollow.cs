using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject target;
    //Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        //offset = target.transform.position - transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }
    
    //Follow target
    private void FollowTarget()
    {

        //transform.position = target.transform.position - offset;
        transform.LookAt(target.transform.position);
    }
}
