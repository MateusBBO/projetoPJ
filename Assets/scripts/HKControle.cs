using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HKControle : MonoBehaviour
{

    Rigidbody2D fisica;
    public float velociade;
    float forcaPulo = 500;    
    




    // Start is called before the first frame update
    void Start()
    {

        fisica = GetComponent<Rigidbody2D>();

      
    }

    // Update is called once per frame
    void Update()
    {

        float taApetando = Input.GetAxis("Horizontal");
       
        fisica.velocity = new Vector2(taApetando*velociade, fisica.velocity.y);
        bool pulei = Input.GetKeyDown(KeyCode.Space);
        if (pulei == true)
        {
            fisica.AddForce(new Vector2(0, forcaPulo));
        }



    }
}
