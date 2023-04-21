using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCamara : MonoBehaviour
{

    public GameObject Personaje;
    private float dondePersonajeX;
    private float dondePersonajeY;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //posicion de la camara=pos pers

        dondePersonajeX = Personaje.transform.position.x;
        dondePersonajeY = Personaje.transform.position.y;


        //Muevo a la camara

        transform.position = new Vector3(dondePersonajeX,dondePersonajeY,-10);
        

        
    }
}
