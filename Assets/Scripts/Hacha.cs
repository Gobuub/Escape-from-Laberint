using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacha : MonoBehaviour
{
    public GameObject VerHacha; //Con este clase le damos la opción al script para elegir un objeto que nosotros queramos dentro de la escena para poder modificarlo

    private void Start()
    {
        VerHacha.SetActive(false); //Desactiva el objeto para que se vea en la IU
    }
    void OnTriggerEnter(Collider other) //función que hace funcionar la llave
    {
        if (other.CompareTag("Player")) //esto sirver para identificar a nuestro jugador y que este pueda recoger la llave
        {

            HachaRecogida.RecogerHacha = true; // transforma la clase recoger llave para indicar que ya tenemos el hacha en nuestro poder

            gameObject.SetActive(false); // oculta el objeto para hacer como que lo hemos cogido

            VerHacha.SetActive(true); //Activa el objeto para que se vea en ka IU

        }

    }
}
