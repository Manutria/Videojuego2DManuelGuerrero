using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverbala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Movimiento.direccionBala == true && Movimiento.ParardireccionBala == false){
            transform.Translate (new Vector2 (Time.deltaTime * 7,0));
        }
        if(Movimiento.direccionBala == false && Movimiento.ParardireccionBala == true){
            transform.Translate (new Vector2 (-Time.deltaTime * 7,0));

            
        }


    }
}
