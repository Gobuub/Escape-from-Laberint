using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float horizontalMove; // variable que determina nuestro movimiento horizontal
    public float verticalMove; // variable que determina nuestro movimiento vertical
    public CharacterController player; // componente character controler asignado a nuestro jugador
    public AudioSource salto; // componente de audio que se reproduce al salta
    private Vector3 playerInput; //variable para que podamos controlar al personaje con un mando, teclado o ratón
   
    public float playerspeed; // variable que determina la velocidad de nuestro personaje
    private Vector3 movePlayer; // variable para poder mover a nuestro personaje
    public float gravity = 9.8f; // variabel que determina la fuerza de gravedad que pondremos en nuestro juego, la cual podemos cambiar para hacer las caidas más "realistas"
    public float fallVelocity; // variable para determinar la fuerza de caida
    public float jumpForce; // variable para controlar el salto
    // con estas variables determinaremos el movimiento de nuestra camara
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;


    // usamos la funcion start para determinar que nuestro jugador tiene un componente character controller asignado
    void Start()
    {
        player = GetComponent<CharacterController>(); //esto nos indica que el jugador tiene un character controller asignado
        salto = GetComponent<AudioSource>(); // esto nos indica que el salto tiene un componente de audio asignado
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        // con estos métodos determinamos como se moverá nuestro personaje por la escena en los ejes x y z

        CamDirection(); // con esta función determinamos el movimiento de la camara
        movePlayer = playerInput.x * camRight + playerInput.z * camForward;

        movePlayer = movePlayer * playerspeed;

        player.transform.LookAt(player.transform.position + movePlayer);

        SetGravity(); // función para establecer el valor de la gravedad

        PlayerSkills(); // función para desarrollar las habilidades que queremos darle a nuestro personaje

       

        player.Move(movePlayer * Time.deltaTime); // función que determina el movimiento de nuestro jugador
    }

    void CamDirection() // función desarrollada para determinar el movimiento de la camara
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;

    }
        
    public void PlayerSkills() //habilidades del personaje
    {
        if (player.isGrounded && Input.GetButtonDown("Jump")) //habilidad de salto
        {
            fallVelocity = jumpForce;
            movePlayer.y = fallVelocity;
            salto.GetComponent<AudioSource>(); 
            salto.Play(); // con este metodo hacemos que se reproduzca el sonido al saltar

            // al apretar el botón le daremos una fuerza al personaje para que pueda superar o igualar la fuerza de caida y este pueda
            
           // despegarse del suelo y volverá a caer en función de la fuerza de la gravedad establecida
        }


    }

    void SetGravity() // función que establece como se comporta y reacciona nuestro personaje a la fuerza de la gravedad
    {
        movePlayer.y = -gravity * Time.deltaTime;

        if (player.isGrounded) //cuando el personaje esté en el suelo esta función hará que nuestro personaje no salga "volando"
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity; 
        }

        else // si por el contrario nuestro personaje ha saltado y no está en el suelo esta función hará que este caiga desde la altura max alcanza
            // a la velocidad que hallamos establecido
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;

        }
    }

    
}