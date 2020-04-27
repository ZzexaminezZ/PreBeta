using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DosDMove : MonoBehaviour
{
    [SerializeField]
    private float VelocidadJugador;
    float CurrentAngle = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Movimientos();
      

    }

    private void Movimientos()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * VelocidadJugador * Time.deltaTime, Space.Self);// Movimiento hacia adelante simple

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * VelocidadJugador * Time.deltaTime, Space.Self);// Movimiento hacia atras simple


        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            CurrentAngle = 0;
            transform.eulerAngles = new Vector3(0, CurrentAngle, 0);

        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            CurrentAngle = 180;
            transform.eulerAngles = new Vector3(0, CurrentAngle, 0);

        }



    }

    
}
