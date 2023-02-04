using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private Rigidbody cameraRB;
    private Vector3 rotation;
    //private Vector3 oldPosition;
    //private Vector3 newPosition;
    private int numberOfOffset;
    //public bool moveCameraIsActive;
    [SerializeField] private Vector3[] offsets = new Vector3[4];
    //[SerializeField] private float speed = 1.0f;
    void Start()
    {
        player = GameObject.Find("Player");
        //cameraRB = GetComponent<Rigidbody>();
        numberOfOffset = 0;
        //moveCameraIsActive = false;

    }

    void LateUpdate()
    {
        //oldPosition = transform.position;
        //newPosition = player.transform.position + offsets[numberOfOffset];
        //if (!moveCameraIsActive)
        //{
        transform.position = player.transform.position + offsets[numberOfOffset];
        // }
        ChangeView();
    }

    void AdjustRotation()
    {
        switch (numberOfOffset)
        {
            case 0:
                rotation = new Vector3(60, 0, 0);
                break;

            case 1:
                rotation = new Vector3(60, -90, 0);
                break;

            case 2:
                rotation = new Vector3(60, -180, 0);
                break;

            case 3:
                rotation = new Vector3(60, -270, 0);
                break;

            default:
                rotation = new Vector3(60, 0, 0);
                break;
        }
        transform.eulerAngles = rotation;
    }
    void ChangeView()
    {
        //moveCameraIsActive = true;
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

            //StartCoroutine(MoveCamera());
        }
    }

    /*IEnumerator MoveCamera()
    {
        var step = speed * Time.deltaTime;


        while (oldPosition != newPosition)
        {
            transform.position = Vector3.Lerp(oldPosition, newPosition, step);
            if(Vector3.Distance(transform.position, newPosition) < 0.17)
            {
                transform.position = newPosition;
            }
            yield return null;
        }
        moveCameraIsActive = false;
    }*/


}
