using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarAire : MonoBehaviour
{
    public string mensaje = "ALTAR AIRE ACTIVADO"; //mensaje que se imprime en pantalla una vez tengamos la llave en nuestro poder
    public ManagerInterfaceAire managerInterface; // método para poder manejar el mensaje que queremos escribir en pantalla
    public Animator Aire; // indica que el objeto tiene un componente de animación
    public AudioSource Activado; // indica que el objeto tiene un componente de audio

    void OnTriggerEnter(Collider other) //función que hace funcionar la llave
    {
        if (other.CompareTag("Player")) //esto sirver para identificar a nuestro jugador y que este pueda recoger la llave
        {

            ActivarAltarAire.AltarElementoAire = true; // transforma la clase recoger llave para indicar que ya tenemos la llave en nuestro poder
            managerInterface.CambiarMensaje(mensaje); // imprime en pantalla el mensaje indicado al principio
            Aire.SetBool("Activar", true); // Activa la transicion de animaciones para que esta se ejecute
            Activado = GetComponent<AudioSource>(); //informa que el objeto tiene una pista de audio asociada
            Activado.Play(); // método que ejecuta la pista de audio

            Debug.Log("Altar de la Aire Activo"); // nos imprime el siguiente mensaje en la consola del juego

        }

    }
}
