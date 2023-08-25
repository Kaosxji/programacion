using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_de_Coches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Ferrari = new Auto();
            Ferrari.modelo = " Ferrari F1";
            Ferrari.velocidad = 120;

            Auto Mclaren = new Auto();
            Mclaren.modelo = " MC 2443";
            Mclaren.velocidad = 140;

            PistaC Pista1 = new PistaC();
            Pista1.nombre = "Hermanos Rodrigez";
            Pista1.longitud = 4.303f;//Km
            Ferrari.PonerGasolina(10);
            Ferrari.Arrancar();
            Mclaren.Arrancar();
            Ferrari.Acelerar();
           Pista1.Competir(Ferrari, Mclaren);
            //Esta linea que presiones enter para continuar
            Console.ReadLine();

        }
    }
}
