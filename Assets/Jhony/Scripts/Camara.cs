using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player;
    public GameObject referencia;
    private Vector3 distancia; 

    private void LateUpdate()
    {
        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;
        Vector3 copiarRotacion = new Vector3(0, transform.eulerAngles.y,0);
        referencia.transform.eulerAngles = copiarRotacion;
        player.transform.eulerAngles = copiarRotacion;
    }

}
