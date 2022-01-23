using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirJaula : MonoBehaviour
{
    public string mensaje = "PARA ACCEDER A LA LLAVE DEBES ACTIVAR LOS 4 PORTALES DE LOS ELEMENTOS"; // mensaje que aparece en pantalla
    public Animator Jaula; // indica que el objeto tiene un componente de animación
    public ManagerInterface managerInterface; // componente para poder manejar lo que vemos en la interface
    public AudioSource JaulaAbierta; // componente que indica que este objeto tiene un audio asociado

    public void OnTriggerEnter(Collider other) // se activa cuando el collider de este objeto entra en contacto con otro collider
    {
        if (ActivarAltarFuego.AltarElementoFuego && ActivarAltarAire.AltarElementoAire && ActivarAltarAgua.AltarElementoAgua && ActivarAltarTierra.AltarElementoTierra)
        // condición para poder activar la función
        {

            Jaula.SetBool("Abrir", true); // este elemento sirve para fijar el factor boleano del script y activar la animación
            JaulaAbierta = GetComponent<AudioSource>(); // con esto indicamos el archivo de audio
            JaulaAbierta.Play(); // con este método activamos el audio

        }

        else // si la anterior parte no se ejecuta porque no se cumplen las condiones entonces se activa este método
        {
            managerInterface.CambiarMensaje(mensaje); // cambiar el mensaje de la interface


        }
    }



}
