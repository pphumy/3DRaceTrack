using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(player1.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(1 / Time.deltaTime);
    }
}
