using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorjugador : MonoBehaviour
{
    public float FuerzadeSalto;
    //ES una refrencia al componete rigidbody2d//
    private Rigidbody2D cuerpo;
    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si en este frame fue presioando el botom para saltar (espacio)
        if (Input.GetButtonDown("Jump"))
       {
            print("se presiono salto");
            cuerpo.AddForce(
                new Vector3(0, FuerzadeSalto, 0),
                ForceMode2D.Impulse);
           

        } 
    }
}
