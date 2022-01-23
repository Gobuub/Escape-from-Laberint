using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInterfaceTierra : MonoBehaviour //Con este script manejamos los mensajes que se imprimen en pantalla durante el juego
{
    public Text mensajePantalla; // método que nos indica el mensaje que podemos poner en pantalla


    public void CambiarMensaje(string mensaje) // función que establece el mensaje que queremos escribir
    {
        mensajePantalla.text = mensaje; //mensaje que saldrá escrito en la pantalla, variará en función del que tengamos activado

    }



}

