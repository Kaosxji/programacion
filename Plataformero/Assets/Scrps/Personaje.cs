using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 80;
    public int hpMax = 100;
    public int vidas = 3;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void danio(int cantidadDanio, GameObject peligro)
    {
        hp = hp - cantidadDanio;
        print(name + " recibe daño de " + cantidadDanio + " por " + peligro);
    }
    public void instaKill(GameObject quien) 
    {
        print(name + " murio instantaneamente po " + quien);
        hp = 0;

    }
}
