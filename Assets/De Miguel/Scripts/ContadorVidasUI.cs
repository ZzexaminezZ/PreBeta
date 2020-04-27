using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorVidasUI : MonoBehaviour
{
    [SerializeField]
    private  Puerta door;
    [SerializeField]
    Image punto;
    [SerializeField]
    Transform Canvas;
    Quaternion bas;
    private static int numllaves;
    private Image[] llavero;

    private Image llave;

    Vector3 origen = new Vector3(0, 0, 0);
    private void Start()
    {
        numllaves = door.GetNumLlaves();
        llavero = new Image[numllaves];
        Vector3 original = this.gameObject.transform.position;
        for (int i = 0; i <= numllaves-1; i++)
        {

            llave = Instantiate(punto, original, bas, Canvas);
            llavero[i] = llave;
            original.x -= 25;
        }
    }

    public bool DestruirLlave()
    {
        Destroy(llavero[numllaves - 1]);
        numllaves -= 1;
        return true;
    }
}
