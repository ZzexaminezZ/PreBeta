using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrappliHook : MonoBehaviour
{
    public GameObject ObjetoTarget;    
    public Transform Zonadeinteraccion;
    public GameObject ObjetivePosicion;
    public GameObject Player;
    Rigidbody Rb;
    LineRenderer Line;

    private void Awake()
    {
        Rb = Player.GetComponent<Rigidbody>();
        Line = Player.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        FireGrappling();
        Line.SetPosition(1, Player.transform.position);
    }

    private void FireGrappling()
    {
        if (ObjetoTarget != null && ObjetoTarget.GetComponent<GrapplinTarget>().Lugarparacolgar == true )
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ObjetivePosicion = ObjetoTarget;
                Line.enabled = true;
               
               

          

                if (Player.transform.position.z < ObjetivePosicion.transform.position.z )
                {
                    Line.SetPosition(0,ObjetivePosicion.transform.position);

                    
                    float z = -ObjetoTarget.transform.position.z;

                    Vector3 target = new Vector3(0, z*2, z);
                    target.Normalize();

                    Rb.AddForce(target*20 , ForceMode.Impulse);
                    Player.GetComponent<DosDMove>().enabled = false;
                    Player.GetComponent<BotasCohete>().enabled = false;
                }

                if (Player.transform.position.z > ObjetivePosicion.transform.position.z)
                {
                    Line.SetPosition(0, ObjetivePosicion.transform.position);

                  
                    float z = ObjetoTarget.transform.position.z;

                    Vector3 target = new Vector3(0,-z*2, z);
                    target.Normalize();

                    Rb.AddForce(target * 20, ForceMode.Impulse);
                    Player.GetComponent<DosDMove>().enabled = false;
                    Player.GetComponent<BotasCohete>().enabled = false;
                }

            }
          

        }      

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "stop")
        {
            Rb.velocity = new Vector3(0, 0, 0);
            Player.GetComponent<DosDMove>().enabled = true;
            Player.GetComponent<BotasCohete>().enabled = true;
            Line.enabled = false;
        }
       
    }
}
