using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Button : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjetoNEcesarioParaActivarse;
    private int Valor;
    [SerializeField]
    private int ValorBoton;

    private void Awake()
    {
        Valor = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Evento_abrir_puerta._AbrirPuerta != null)
        {
            if (other.tag == ObjetoNEcesarioParaActivarse.tag.ToString())
            {
                Valor = ValorBoton;
                Evento_abrir_puerta._AbrirPuerta(Valor);
            }
        }                
    }
    private void OnTriggerExit(Collider other)
    {
        if (Evento_abrir_puerta._AbrirPuerta != null)
        {
            if (other.tag == ObjetoNEcesarioParaActivarse.tag.ToString())
            {
                Valor = - ValorBoton;
                Evento_abrir_puerta._AbrirPuerta(Valor);
            }
        }                   
    }
}

