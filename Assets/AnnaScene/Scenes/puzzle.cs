using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour
{

    public MovingTubes[] movint;
    public bool Win = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Win) //si tiene !win por defetco es false
        {
            return;
            Debug.Log("HAZZZ GANADOPOOOOO");
        }
        foreach (var item in movint)
        {
            if (item.victoryAngle != item.CurrentAngle)
            {
                return;
            }
        }

        PuzzleWinEvent._WinEvent();
        Win = true;
        //se abre la puerta
        

    }

}
