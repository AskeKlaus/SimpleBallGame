using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocalPointRotation : MonoBehaviour
{
    private int activeCamera;
    private Vector3 rotation;
    void Start()
    {

    }

    void Update()
    {
        AdjustRotation();
    }

    void AdjustRotation()
    {
        activeCamera = CameraSwitcher.numberOfCamera;
        switch (activeCamera)
        {
            case 0:
                rotation = new Vector3(0, 0, 0);
                break;

            case 1:
                rotation = new Vector3(0, -270, 0);
                break;

            case 2:
                rotation = new Vector3(0, -180, 0);
                break;

            case 3:
                rotation = new Vector3(0, -90, 0);
                break;

            default:
                rotation = new Vector3(0, 0, 0);
                break;
        }
        transform.eulerAngles = rotation;
    }
}
