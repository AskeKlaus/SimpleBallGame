using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class CameraSwitcher
{
    public static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

    public static CinemachineVirtualCamera ActiveCamera = null;

    public static void SwitchCamera(CinemachineVirtualCamera cam)
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

    public static void Register(CinemachineVirtualCamera cam)
    {
        cameras.Add(cam);
    }

    public static void Unregister(CinemachineVirtualCamera cam)
    {
        cameras.Remove(cam);
    }
}
