using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private Vector3 rotation;
    private int numberOfOffset;
    [SerializeField] private Vector3[] offsets = new Vector3[4];
    void Start()
    {
        player = GameObject.Find("Player");
        numberOfOffset = 0;
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (numberOfOffset < offsets.Length - 1)
            {
                numberOfOffset++;
            }
            else numberOfOffset = 0;
            AdjustRotation();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (numberOfOffset > 0)
            {
                numberOfOffset--;
            }
            else numberOfOffset = offsets.Length - 1;
            AdjustRotation();
        }
        transform.position = player.transform.position + offsets[numberOfOffset];


    }

    void AdjustRotation()
    {
        switch (numberOfOffset)
        {
            case 0:
                rotation = new Vector3(0, 0, 0);
                break;

            case 1:
                rotation = new Vector3(0, -90, 0);
                break;

            case 2:
                rotation = new Vector3(0, -180, 0);
                break;

            case 3:
                rotation = new Vector3(0, -270, 0);
                break;

            default:
                rotation = new Vector3(0, 0, 0);
                break;
        }
        transform.eulerAngles = rotation;
    }
}