using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator animDoor;
    public AudioSource doorOpen;

    // Start is called before the first frame update
    void Start()
    {
        animDoor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        animDoor.SetTrigger("OpenGate");
        doorOpen.Play();
    }
    

    public void OnTriggerExit(Collider other)
    {
        animDoor.enabled = true;
        doorOpen.Play();
    }
    public void StopAnimDoor()
    
    {
        animDoor.enabled = false;
    }
}
