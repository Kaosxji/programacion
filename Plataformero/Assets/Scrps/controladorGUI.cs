using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorGUI : MonoBehaviour
{
    public Personaje Heroe;
    public Text EtiquetaHPHeroe;
    public Image BarraHPHeroe;
    public Text Score;
    public Text Vidas;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        EtiquetaHPHeroe.text = Heroe.hp + "/" + Heroe.hpMax;

        float porcentajeHPHeroe = Heroe.hp / (float)Heroe.hpMax;
        BarraHPHeroe.fillAmount = porcentajeHPHeroe;

        Score.text = Heroe.score + "";

        float pScore = Heroe.score;

        Vidas.text = Heroe.vidas + "";
        float pVidas = Heroe.vidas;

    }
}
