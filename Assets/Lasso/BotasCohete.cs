using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotasCohete : MonoBehaviour
{
    [SerializeField]
    private Image BotsFuel;
    Rigidbody rb;
    [SerializeField]
    private float UseTime = 0;
    [SerializeField]
    private float MAxUseTime = 1;
    Animator MyAnim;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.root.GetComponent<Rigidbody>();
        MyAnim = GetComponent<Animator>();
        animacion();
    }

    // Update is called once per frame
    void Update()
    {
        Cohete();
        animacion();
    }

    private void animacion()
    {
        BotsFuel.fillAmount = (MAxUseTime - UseTime);

    }
    private void Cohete()
    {
       

        if (UseTime <= MAxUseTime )
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0, 13f, 0);
                UseTime += Time.deltaTime;
            }
            else
            {
                UseTime -= Time.deltaTime;
            }
            
        }
        else
        {
            UseTime = MAxUseTime;
            
        }
        
        
            
        


        if (UseTime < 0)
        {
            UseTime = 0;
        }
        
      
    }
}
