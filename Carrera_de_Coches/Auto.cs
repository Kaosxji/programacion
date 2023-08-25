using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_de_Coches
{
    public class Auto
    {
        public string modelo;
        public Color color;
        public float velocidad;
        public float gasolina;
        public void Arrancar()
        {
            if (gasolina > 0)
            {
                gasolina = gasolina - 0.1f;
                Console.WriteLine("Arrancando" + modelo + ", le quedan" + gasolina + "1 de gas");
            }
            else
            {
                Console.WriteLine(modelo + "no tiene gasolina, no puede arrancar");
            }
        }
        public void PonerGasolina(float cantidad)
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine(" se puso gasolina a " + modelo + "Ahora tiene " + gasolina + "1.");
        }
        public void Acelerar(float ACE)
        {
            if (gasolina > 0)
            {
                velocidad = velocidad + ACE;
                gasolina = gasolina - 1 / 10 * ACE;
                Console.WriteLine(modelo + " Va a" + velocidad + "Km/h");
                Console.WriteLine(" gasolina a disminuido " + gasolina);
            }
            else 
            {
                Console.WriteLine(modelo + "Se quedo sin gasolina");
            }
        }
    }
}
