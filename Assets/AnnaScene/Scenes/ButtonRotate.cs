using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    [SerializeField]
    public bool isPressed = false;

    private void Update()
    {
        Accionar();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Player")
        {
            isPressed = true;
     
        }



    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isPressed = false;
            //Debug.Log("sali");
        }
    }

    private void Accionar()
    {

        if (Input.GetKeyDown(KeyCode.E)&&isPressed== true)
        {
            RooTMovEvent._Mover();
        }

    }
}
