using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Start : MonoBehaviour // Script del Menú Principal
{
    
    // con esta función hacemos que nuestro juego se inicie
    void Update()
    {
        if (Input.GetKeyDown("return")) //Si pulsamos la tecla asignada se activará el método e iniciaremos el juego
        {
            SceneManager.LoadScene(1); //Con esta clase cambiamos de escena y pasamos a la escena principal de nuestro juego
            
        }

        else //en cambio si pulsamos esta otra tecla se iniciará el manager de escenas y cargará la escena indicada
        {
            if (Input.GetKeyDown("h"))
            {

                SceneManager.LoadScene(2);
                

            }

            else //en cambio si pulsamos esta otra tecla el juego se cerrará y volverá al sistema operativo
            {
                if (Input.GetKeyDown("escape"))

                
                Application.Quit();
                    
            }
        }
    }

    
}
