using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 3.5f;

    public float salto = 3f;
    
    bool saltando = false;

    Rigidbody2D miCuerpoRigido;

    Animator controlAnimacion;

    public static bool direccionBala = false;
    public static bool ParardireccionBala = false;

    void Awake()
    {
     
       DontDestroyOnLoad(gameObject);
    
    }

    // Start is called before the first frame update
    void Start()
    {
        miCuerpoRigido = GetComponent<Rigidbody2D>();
        controlAnimacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

     if (principalScript.Vida > 0){
        //Obtengo valor de las teclas a-d
       float movTeclas = Input.GetAxis ("Horizontal")*velocidad;  
      
      //convierto a metros por segundo
       movTeclas *= Time.deltaTime;
       transform.Translate(movTeclas,0,0);

       //si, la tecla apretada es A rota la x a -1

       if(Input.GetKeyDown(KeyCode.A)){
            transform.localScale = new Vector3(-1,1,1);
            controlAnimacion.SetBool("activarCamina", true);
            direccionBala = false;
            parallax.DireccionPersonaje = "izquierda";
       }
       
       if(Input.GetKeyDown(KeyCode.D)){
            transform.localScale = new Vector3(1,1,1);
            controlAnimacion.SetBool("activarCamina", true);
            direccionBala = true;
            ParardireccionBala = true;
            parallax.DireccionPersonaje = "derecha";
       }

       if(Input.GetKeyUp(KeyCode.A)){
          controlAnimacion.SetBool("activarCamina", false);
          ParardireccionBala = true;
          parallax.DireccionPersonaje = "parado";
       }

       if(Input.GetKeyUp(KeyCode.D)){
          controlAnimacion.SetBool("activarCamina", false);
          ParardireccionBala = false;
          parallax.DireccionPersonaje = "parado";
        }
     }//final vida
       //salto
       
       if(Input.GetKeyDown(KeyCode.Space) && saltando == false){
          miCuerpoRigido.AddForce(new Vector2(0,5f),ForceMode2D.Impulse);
          saltando=true;
       
        }



     }   

     void OnCollisionEnter2D(){
          saltando = false;
     }
}
