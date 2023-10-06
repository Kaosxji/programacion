using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonaMuerta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject Objeto1 = collision.gameObject;
        if (Objeto1.tag == "Player")
        {
            print(name + " detecte colision con " + collision.gameObject);

            Personaje Perso = Objeto1.GetComponent<Personaje>();

            Perso.instaKill(this.gameObject);
            GameObject efectoSplash = Instantiate(splashAguaPrefab);
            efectoSplash
        }
    }
}
}
