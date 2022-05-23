using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarasigue : MonoBehaviour
{

    public Transform maggie;
    public Vector3 camOffset;

    [Range(0.1f, 1.0f)]
    public float SmoothFactor = 0.1f;

    public bool rotationActive= true;
    public float velRotation = 5.0f;

    public bool lookAtMaggie = false;

    void Start()
    {
        camOffset = transform.position - maggie.position;   
    }

    void FixedUpdate()
    {
        if(rotationActive)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse X") * velRotation, Vector3.up);

            camOffset = camTurnAngle * camOffset;
        }

        Vector3 newPos = maggie.position + camOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (lookAtMaggie || rotationActive)
        {
            transform.LookAt(maggie);
        }

        if (Input.GetButton("firel"))
        {
            rotationActive = true;
        }
        else
        {
            rotationActive = false;
            transform.LookAt(maggie);
        }
    }
}