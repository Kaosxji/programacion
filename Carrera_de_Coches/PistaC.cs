using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_de_Coches
{
    public class PistaC
    {
        public string nombre;
        public float longitud;

        public void Competir(Auto auto1, Auto auto2)
        { //este es el bloque del metodo
             Console.WriteLine("Iniciando la competencia entre" + auto1.modelo + "contra" + auto2.modelo);

            if (auto1.velocidad > auto2.velocidad)
            {
                Console.WriteLine("Gano" + auto2.modelo);
            }
            if(auto2.velocidad > auto1.velocidad)
            {
                Console.WriteLine("Gano" + auto1.modelo);
            }
            else
            {
                Console.WriteLine("Hubo un empate XD");
            }
           
        }
