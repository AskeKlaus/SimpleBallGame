using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineController : MonoBehaviour
{
    public static int numberOfCamera = 0;
    [SerializeField] CinemachineVirtualCamera frontCam;
    [SerializeField] CinemachineVirtualCamera rightCam;
    [SerializeField] CinemachineVirtualCamera backCam;
    [SerializeField] CinemachineVirtualCamera leftCam;


    private void OnEnable()
    {
        CameraSwitcher.Register(frontCam);
        CameraSwitcher.Register(rightCam);
        CameraSwitcher.Register(backCam);
        CameraSwitcher.Register(leftCam);
        CameraSwitcher.SwitchCamera(frontCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(frontCam);
        CameraSwitcher.Unregister(leftCam);
        CameraSwitcher.Unregister(rightCam);
        CameraSwitcher.Unregister(backCam);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (numberOfCamera < CameraSwitcher.cameras.Count - 1)
                {
                    numberOfCamera++;
                }
                else numberOfCamera = 0;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (numberOfCamera > 0)
                {
                    numberOfCamera--;
                }
                else numberOfCamera = CameraSwitcher.cameras.Count - 1;
            }
            CameraSwitcher.SwitchCamera(CameraSwitcher.cameras[numberOfCamera]);
        }
    }
}
