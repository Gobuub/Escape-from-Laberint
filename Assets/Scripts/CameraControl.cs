using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour //Script para poder controlar y manejar la cámara del juego con el ratón
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // estos parámetros nos ayudan a fijar la velocidad y el movimiento de la cámara

   
   // en la función update proporcionamos los datos para que la camara reaccione al movimiento del ratón
    void Update()
    {

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}
