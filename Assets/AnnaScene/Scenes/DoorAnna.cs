using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnna : MonoBehaviour
{

   


    private void Start()
    {

         PuzzleWinEvent._WinEvent+= MoverPuerta;
    }

    public void MoverPuerta()
    {        
        float x = this.transform.position.x;
        float z = this.transform.position.z;

          this.transform.position = new Vector3(x, 7.25f, z);   
    }
}
