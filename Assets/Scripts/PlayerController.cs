using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject focalPoint;
    [SerializeField] private float speed = 1;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float sideInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
        playerRb.AddForce(focalPoint.transform.right * sideInput * speed);
    }
}
