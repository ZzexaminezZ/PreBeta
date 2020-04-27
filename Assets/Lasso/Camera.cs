using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform PlayerTransform;

    private Vector3 _Cameraoffset;

    public float Smooth = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _Cameraoffset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = PlayerTransform.position + _Cameraoffset;

        transform.position = Vector3.Slerp(transform.position, newPos, Smooth);
    }
}
