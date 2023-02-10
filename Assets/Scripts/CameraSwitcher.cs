using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class CameraSwitcher
{
    public static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

    public static CinemachineVirtualCamera ActiveCamera = null;
    public static int numberOfCamera = 0;

    public static void ChooseActiveCamera(CinemachineVirtualCamera cam)
    {
        cam.Priority = 10;
        ActiveCamera= cam;

        foreach(CinemachineVirtualCamera c in cameras)
        {
            if(c != cam && c.Priority != 0)
            {
                c.Priority = 0;
            }
        }
    }

    public static void SwitchCamera()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (numberOfCamera < cameras.Count - 1)
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
                else numberOfCamera = cameras.Count - 1;
            }
            ChooseActiveCamera(cameras[numberOfCamera]);
        }
    }

    public static void Register(CinemachineVirtualCamera cam)
    {
        cameras.Add(cam);
    }

    public static void Unregister(CinemachineVirtualCamera cam)
    {
        cameras.Remove(cam);
    }
}
