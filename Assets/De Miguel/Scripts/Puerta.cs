using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField]
    private GameObject[] llaves;
    [SerializeField]
    private ContadorVidasUI Ui;

    public int ContLlaves, numeroLlaves;

    public int GetNumLlaves() { return llaves.Length; }
 
    private void Start()
    {
        ContLlaves = 0;
        numeroLlaves = llaves.Length;
        EventoColission._CogerLlave += SumaLlave;
        

    }
    private void Update()
    {
        MoverPuerta();
    }
    public void SumaLlave()
    {
        Ui.DestruirLlave();
        ContLlaves++;    
    }
    public void MoverPuerta()
    {
        if (ContLlaves == 4)
        {
            
                this.gameObject.transform.Translate(Vector3.up * Time.deltaTime * 5);
            
        }

    }
}
