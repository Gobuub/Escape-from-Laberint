using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour //script para volver al menú principal en cualquier momento del juego
{
    void Update()
    {
        if(Input.GetKey("escape")) // si pulsamos esta tecla el juego volvera al menu principal
        {
            SceneManager.LoadScene(0); // carga la escena del menú principal

        }
    }
}
