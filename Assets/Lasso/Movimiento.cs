using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{
    
    [SerializeField]
    private float VelocidadJugador;
    private float Rotacion = 50;
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        Movimientos();
        Rotaciones();
       
    }

    private void Movimientos()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*VelocidadJugador*Time.deltaTime,Space.Self);// Movimiento hacia adelante simple
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * VelocidadJugador * Time.deltaTime,Space.Self);// Movimiento hacia atras simple
        }

    }

    private void Rotaciones()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, -Rotacion, 0f) * Time.deltaTime);// Rotacion hacia la izquierda
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, Rotacion, 0f) * Time.deltaTime);// Rotacion Hacia la derecha
        }


    }

   
}
