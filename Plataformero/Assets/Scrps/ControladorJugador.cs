using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    private Rigidbody2D miCuerpo;
    private Animator miAnimator;
    // Start is called before the first frame update
    void Start()
    {
        miAnimator = GetComponent<Animator>();
        miCuerpo = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = miCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0)
        {//se mueve a la derecha
            transform.rotation =
                Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);
            miAnimator.SetBool("Caminata", true);
        }
        else if (movHoriz < 0)
        {//se mueve a la izquierda 
            transform.rotation =
                Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velVert, 0);
            miAnimator.SetBool("Caminata", true);
        }
        else
        {//no se mueve 
            miCuerpo.velocity = new Vector3(0, velVert, 0);
            miAnimator.SetBool("Caminata", false);
        }
    }
}
