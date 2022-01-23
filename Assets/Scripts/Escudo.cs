using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    public GameObject VerEscudo; //Con este clase le damos la opción al script para elegir un objeto que nosotros queramos dentro de la escena para poder modificarlo

    private void Start()
    {
        VerEscudo.SetActive(false); //Desactiva el objeto para que no se vea en la IU

    }

    void OnTriggerEnter(Collider other) //función que nos permite coger la llave
    {
        if (other.CompareTag("Player")) //esto sirver para identificar a nuestro jugador y que este pueda recoger la llave
        {

            EscudoRecogido.RecogerEscudo = true; // transforma la clase recoger escudo para indicar que ya tenemos el escudo en nuestro poder

            gameObject.SetActive(false); // oculta el objeto para hacer como que lo hemos cogido

            VerEscudo.SetActive(true); //Activa el objeto para que se vea en la IU
            
        }

    }
}
