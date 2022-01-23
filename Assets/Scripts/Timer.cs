using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour // script para controlar el temporizador
{
    public Text temporizadorUI; //componente para editar el texto del temporizador
    public float tiempo = 120f; // variable para asignar el valor del temporizador
    

    private void Start()
    {
        temporizadorUI.text = " " + tiempo; // metodo para iniciar el temporizador
    }

    private void Update()
    {
        tiempo -= Time.deltaTime; // función para hacer que el temporizador vaya hacia atras

        temporizadorUI.text = tiempo.ToString("f0"); // función que nos actualizar el valor del temporizador

        if (tiempo <= 0) // metodo que se inicia si el temporizador llega a 0
        {
            SceneManager.LoadScene(4); // metodo para cargar la escena elegida
            
            
        }
    }


}

    
   

