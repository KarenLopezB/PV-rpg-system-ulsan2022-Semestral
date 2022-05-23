using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float speddH;
    public float speedV;

    float yaw;
    float pitch;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += speddH + Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
