using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject focalPoint;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float sideInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(focalPoint.transform.forward * forwardInput);
        playerRb.AddForce(focalPoint.transform.right * sideInput);
    }

    void Move()
    {
        
    }
}
