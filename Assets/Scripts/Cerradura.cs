using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Cerradura : MonoBehaviour

    //Es script es el que hace que funcione nuestro mecanismo para abrir la puerta del laberinto
{
    public string mensaje = "PARA SALIR DEBES DE ENCONTRAR LA LLAVE PRIMERO"; // mesanje que aparece en pantalla
    public string mensaje1 = "ANTES DE SALIR ENCUENTRA UN HACHA Y UN ESCUDO";

    // Nos imprime en pantalla el mensaje
    public Animator PuertaFinal;

    // Llama a la animación que queremos ejecutar
    public ManagerInterface managerInterface;

    // Esta clase hace que podamos manejar los mensajes que se publican en la pantalla del juego

    public AudioSource Victoria; // esto nos dice que el objeto tiene una pista de sonido

    
    private void OnTriggerEnter(Collider other) // se activa cuando el collider de este objeto entra en contacto con otro collider

    // Función que detecta si nuestro personaje tiene o no la llave y activa el mecanismo para abrir la puerta, en nuestro caso
    // activa la animación de abrir puerta
    {
        if (RecogerLlave.LlaveRecogida && EscudoRecogido.RecogerEscudo && HachaRecogida.RecogerHacha) // Si nuestro personaje tiene la llave se ejecutará este método
        {

            PuertaFinal.SetBool("abrir", true); //Activa la animación de apertura de puerta
            Victoria = GetComponent<AudioSource>(); //identifica la pista de sonido
            Victoria.Play(); // reproduce el sonido indicado

            Debug.Log("Abrir Puerta"); // imprime este mensaje en la consola
        }

        else // Si nuestro personaje no tiene aún la llave se ejecutará este otro
        {
            if (RecogerLlave.LlaveRecogida)
            {
                managerInterface.CambiarMensaje1(mensaje1); // Nos imprime en pantalla el mensaje escrito el mensaje del principio

                Debug.Log("Antes de salier encuentra un Hacha y un Escudo"); // imprime este mensaje en la consola
            }

            else

            {
                managerInterface.CambiarMensaje(mensaje); // Nos imprime en pantalla el mensaje escrito el mensaje del principio

                Debug.Log("Para poder salir tienes que tener la llave secreta"); // imprime este mensaje en la consola

            }
        
        }
    }
}
