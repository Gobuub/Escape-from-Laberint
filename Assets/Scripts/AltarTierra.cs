using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarTierra : MonoBehaviour
{
    public string mensaje = "ALTAR TIERRA ACTIVADO"; //mensaje que se imprime en pantalla una vez tengamos la llave en nuestro poder
    public ManagerInterfaceTierra managerInterface; // método para poder manejar el mensaje que queremos escribir en pantalla
    public Animator Tierra; // indica que el objeto tiene un componente de animación
    public AudioSource Activado; // indica que el objeto tiene un componente de audio

    void OnTriggerEnter(Collider other) //función que hace funcionar la llave
    {
        if (other.CompareTag("Player")) //esto sirver para identificar a nuestro jugador y que este pueda recoger la llave
        {

            ActivarAltarTierra.AltarElementoTierra = true; // transforma la clase recoger llave para indicar que ya tenemos la llave en nuestro poder
            managerInterface.CambiarMensaje(mensaje); // imprime en pantalla el mensaje indicado al principio
            Tierra.SetBool("Activar", true); // Activa la transicion de animaciones para que esta se ejecute
            Activado = GetComponent<AudioSource>(); //informa que el objeto tiene una pista de audio asociada
            Activado.Play(); // método que ejecuta la pista de audio

            Debug.Log("Altar de la Tierra Activo"); // nos imprime el siguiente mensaje en la consola del juego

        }

    }
}

