using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContactoEscena : MonoBehaviour
{
    [SerializeField]
    private string NombreEscena;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(NombreEscena);
        }

    }
}
