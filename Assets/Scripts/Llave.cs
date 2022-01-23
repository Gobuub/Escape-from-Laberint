using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour // script contenedor de la llave para que podamos avanzar en nuestro juego y poder abrir la puerta
{
    public string mensaje = "ENCUENTRA LA SALIDA SECRETA"; //mensaje que se imprime en pantalla una vez tengamos la llave en nuestro poder
    public ManagerInterface managerInterface; // método para poder manejar el mensaje que queremos escribir en pantalla
    

    void OnTriggerEnter(Collider other) //función que hace funcionar la llave
    {
        if (other.CompareTag("Player")) //esto sirver para identificar a nuestro jugador y que este pueda recoger la llave
        {

            RecogerLlave.LlaveRecogida = true; // transforma la clase recoger llave para indicar que ya tenemos la llave en nuestro poder

           
            managerInterface.CambiarMensaje(mensaje); // imprime en pantalla el mensaje indicado al principio
            gameObject.SetActive(false); // oculta la llave a la vista una vez que la hemos cogido, para simular que la guardamos en "nuestro bolsillo"
            
        }

    }
}
