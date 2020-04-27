using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Doors : MonoBehaviour
{
    [SerializeField]
    private float ValorNecesarioParaAbrir = 0;
    [SerializeField]
    private float CountPuerta = 0;
    
    

    private void Start()
    {
       
        Evento_abrir_puerta._AbrirPuerta += MoverPuerta;
    }

    public  void MoverPuerta(int id)
    {       
        CountPuerta += id;

        float x = this.transform.position.x;        
        float z = this.transform.position.z;
        
        if (CountPuerta == ValorNecesarioParaAbrir)
        {
            this.transform.position = new Vector3(x, 7.25f, z);
                
        }
        else if (CountPuerta < ValorNecesarioParaAbrir)
        {
            this.transform.position = new Vector3(x, 2.50f, z);
        }
        
               
          
            
             
    }
}
