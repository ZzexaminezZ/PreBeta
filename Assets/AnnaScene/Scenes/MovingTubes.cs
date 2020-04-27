using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTubes : MonoBehaviour
{
    private float speed = 2.5f;
    public ButtonRotate[] centerRotation;
    [SerializeField]
    public float victoryAngle;
    private float currentAngle;

    public float CurrentAngle { get => currentAngle; set => currentAngle = value >= 360 ? value % 360 : (value < 0 ? 360 - ((-value) % 360) : value); }




    // Start is called before the first frame update
    void Start()
    {
        CurrentAngle =(int)transform.eulerAngles.y;
        RooTMovEvent._Mover += Move;


    }

    private void Move()
    {
        foreach (var item in centerRotation)
        {
            if (item.isPressed == true)
            {

                CurrentAngle += 90;
                transform.eulerAngles = new Vector3(0, CurrentAngle, 0);

                //print(rotTransform.eulerAngles);

            }   
        }
        Debug.Log(transform.eulerAngles.y == victoryAngle,gameObject);
        //centerRotation.transform.Rotate
        

    }
    
}
