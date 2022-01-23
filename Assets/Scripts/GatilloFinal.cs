using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GatilloFinal : MonoBehaviour // Con este script realizaremos un cambio de escena al pasar por la puerta del final
{

    private void OnTriggerEnter(Collider other) //Si el jugador entra en contacto con el collider se activa el siguiente método
    {
        if (other.CompareTag("Player")) //Si nuestro "jugador" tiene la etiqueta de "Player" y entra en contacto con el collider se activará
        {

            SceneManager.LoadScene(3); //Con esto llamamos al método de cambiar de escena, en este caso nos lleva a la escena de creditos
            
        }
    }
}
