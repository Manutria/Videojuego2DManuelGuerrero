using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{

    public string clonBala;

    float SpeedEnemigo = 0.6f;

    float DiastanciaPlayer = 7f;

    Vector3 posicionInicial;

    public GameObject player;


    void OnTriggerEnter2D(Collider2D col){

        clonBala = col.gameObject.name;

        if(clonBala == "bala(Clone)"){
            principalScript.Enemigos++;
            Destroy(this.gameObject, 0.3f);
        }
        if(clonBala == "Personaje"){
            principalScript.Vida--;
            player.transform.position = new Vector2 (-9.37f,-0.41f);
        }



    }



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        posicionInicial = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Objetivo = posicionInicial;
        float distancia = Vector3.Distance(player.transform.position,transform.position);
        if(distancia < DiastanciaPlayer){
            Objetivo= player.transform.position;

        }
        float Velocidadfija = SpeedEnemigo*Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position,Objetivo,Velocidadfija);

    }
}
