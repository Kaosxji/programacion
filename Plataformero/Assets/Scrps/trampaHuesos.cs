using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampaHuesos : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {//este metodo se disoara cuanto este objeto detecta una colision
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player") 
        {
            print(name + " detecte colision con " + collision.gameObject);

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();

            elPerso.danio(20, gameObject);
        }
        

    }
   
}
