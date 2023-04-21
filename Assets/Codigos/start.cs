using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public GameObject CanvasStart;
    public GameObject CanvasControles;




    // Start is called before the first frame update
    void Start()
    {
       CanvasControles.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntrarJuego(){
        SceneManager.LoadScene("Nivel1");
    }
    public void MostrarControles(){
        CanvasStart.SetActive(false);
        CanvasControles.SetActive(true);

    }
    public void IraStart(){
        CanvasControles.SetActive(false);
        CanvasStart.SetActive(true);
            
    }




}
