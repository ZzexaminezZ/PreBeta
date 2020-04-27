using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableCube : Pickable

{   

    public override   void   OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickObject>().ObjectToPickUp = this.gameObject;
        }
    }
    public override void OnTriggerExit(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickObject>().ObjectToPickUp = null;
        }
    }
}
