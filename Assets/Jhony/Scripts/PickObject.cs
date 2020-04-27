using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour
{
    
    public GameObject ObjectToPickUp;
    public GameObject PikedObject;
    public Transform InteracionZone;

    private void Update()
    {
        Pickear();
    }


    private void Pickear()
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableCube>().IsPickable == true && PikedObject == null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {               
                PikedObject = ObjectToPickUp;
                PikedObject.GetComponent<PickableCube>().IsPickable = false;
                PikedObject.transform.SetParent(InteracionZone);
                PikedObject.transform.position = InteracionZone.position;
                PikedObject.GetComponent<Rigidbody>().useGravity = false;
                PikedObject.GetComponent<Rigidbody>().isKinematic = true;
            }

           
        }
        else if (Input.GetKeyDown(KeyCode.E) && ObjectToPickUp != null)
        {

            PikedObject.GetComponent<PickableCube>().IsPickable = true;
            PikedObject.transform.SetParent(null);
            PikedObject.GetComponent<Rigidbody>().useGravity = true;
            PikedObject.GetComponent<Rigidbody>().isKinematic = false;
            PikedObject = null;

        }

    }

}
