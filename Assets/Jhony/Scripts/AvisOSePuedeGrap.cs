using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvisOSePuedeGrap : MonoBehaviour
{
    public GameObject aviso;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            aviso.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag== "Player")
        {
            aviso.SetActive(false);
        }
       
    }

}
