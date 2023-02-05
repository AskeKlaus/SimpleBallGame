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
        activeCamera = CinemachineController.numberOfCamera;
        AdjustRotation();
    }

    void AdjustRotation()
    {
        switch (activeCamera)
        {
            case 0:
                rotation = new Vector3(60, 0, 0);
                break;

            case 1:
                rotation = new Vector3(60, -270, 0);
                break;

            case 2:
                rotation = new Vector3(60, -180, 0);
                break;

            case 3:
                rotation = new Vector3(60, -90, 0);
                break;

            default:
                rotation = new Vector3(60, 0, 0);
                break;
        }
        transform.eulerAngles = rotation;
    }
}
