using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarasigue : MonoBehaviour
{

    public Transform player;
    public Vector3 camOffset;

    [Range(0.1f, 1.0f)]
    public float SmoothFactor = 0.1f;

    public bool rotationActive= true;
    public float velRotation = 5.0f;

    public bool lookAtPlayer = false;

    void Start()
    {
        camOffset = transform.position - player.position;   
    }

    void FixedUpdate()
    {
        if(rotationActive)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse X") * velRotation, Vector3.up);

            camOffset = camTurnAngle * camOffset;
        }

        Vector3 newPos = player.position + camOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (lookAtPlayer || rotationActive)
        {
            transform.LookAt(player);
        }

        if (Input.GetButton("firel"))
        {
            rotationActive = true;
        }
        else
        {
            rotationActive = false;
            transform.LookAt(player);
        }
    }
}