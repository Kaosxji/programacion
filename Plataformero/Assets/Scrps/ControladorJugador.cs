using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;
    private Animator MiAnimator;
    // Start is called before the first frame update
    void Start()
    {
        MiAnimator = GetComponent<Animator>();
        MiCuerpo = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = MiCuerpo.velocity.y;
        MiCuerpo.velocity = new Vector3(5, velVert, 0);
        MiAnimator.SetBool("Caminata", true);
    }
}
