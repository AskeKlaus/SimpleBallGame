using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineController : MonoBehaviour
{
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
        CameraSwitcher.ChooseActiveCamera(frontCam);
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
        CameraSwitcher.SwitchCamera();
    }
}
