using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Ciudades = {"Osaka", "Tokyo","Seul",
             "Puebla", "Montreal","paris","Londres","Okinawa"
            };

            int cantElems = Ciudades.Length;
            Console.WriteLine(" El arreglo tiene " + cantElems + " elemnetos ");
            

            //acceder a los elementos del arreglo
            string segundaCiudad = Ciudades[1];
            string ciudad4 = Ciudades[4];
            Console.WriteLine(segundaCiudad);
            Console.WriteLine(ciudad4);
            Console.WriteLine(Ciudades[0]);
            Console.WriteLine(Ciudades[5]);

            //Modifico elemento de un arreglo
            Ciudades[4] = "Otawa";
            Console.WriteLine(Ciudades[4]);
            for(int i = 0; i < 8; i++) 
            {//Esta Hardcodeado el 8

            }
            for (int i = 0; i < Ciudades.Length; i++)
            {//Parametrizado
                Console.WriteLine(i + ".-" + Ciudades[i]);
            }
            Console.Read();
        }
    }
}
