using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickable : MonoBehaviour
{
    protected bool isPickable = true;

    [SerializeField]
    private string objectName;



    public bool IsPickable { get => isPickable; set => isPickable = value; }
    public string ObjectName { get => objectName; set => objectName = value; }
    

    public abstract void OnTriggerEnter(Collider other);


    public abstract void OnTriggerExit(Collider other);
    
}
