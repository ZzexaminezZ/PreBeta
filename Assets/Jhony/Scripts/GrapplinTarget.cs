using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplinTarget : MonoBehaviour
{

    [SerializeField]
    private bool TargetForHook = true;



    public bool Lugarparacolgar { get => TargetForHook; set => TargetForHook = value; }


    public  void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GrapplinInteractionZone")
        {
            other.GetComponentInParent<PlayerGrappliHook>().ObjetoTarget = this.gameObject;
        }
    }
    public  void OnTriggerExit(Collider other)
    {
        if (other.tag == "GrapplinInteractionZone")
        {
            other.GetComponentInParent<PlayerGrappliHook>().ObjetoTarget = null;
        }
    }
}
