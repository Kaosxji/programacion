using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresEnArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PrimerNombre = {" Asmud/Aslaug "," Bjord/Belinda "," Cade/Cadence ",
         " Dagiff/Dagmar "," Edan/Edda "," Floki/Freja "," Georg/Grete "," Hvitserk/Hege ",
         " Ivar/Ingrid "," Jorge/Jytte "," Kennet/Katerin "," Leif/Largertha "," Magnua/Magda ",
         " Niklaus/Nadia ", " Olaf/Ophelia "," Knute/Karan "," Laerke/Frederik "," Ragnar/Ragnild",
         " Sigurd/Siggy "," Thor/Torvi ", " Ubbe/Uma "," Vilhelm/Valda","Viggo/Astrid","Rollo/Rhea",
         "Yngvard"
            };

            int cantElms = PrimerNombre.Length;
            Console.WriteLine($"¿cual es tu nombre vikingo?{Environment.NewLine}{Environment.NewLine}Inicial De tu Nombre:{Environment.NewLine}");

            //elementos del arreglo
            for (int i = 0; i < PrimerNombre.Length; i++)
            {
                Console.WriteLine(i + ".-" + PrimerNombre[i]);
            }

            string[] SegundoNombre = { " The Bold ", " IronSide ", " The Red ", " The Braggart ", " The Crow ", " Halfhand "
         ," The Innicent ", " The Fearless ", " Hollowwleg ", " Jorgansen ", " Bearclaw ", " The Blackthorn ",
          " Whitemane ", " Ravencrone "," Swiftseer ", " The Rotten ", " The Slayer ", " Rockbreaker ", " Stoutspear ",
          " The Smith ", " Unminded ", " The Laggard ", " Windrimer ", " The Pickled ", " The Younger ", "The Broeken"
            };

            int cantElms2 = SegundoNombre.Length;
            Console.WriteLine($"{Environment.NewLine}Inicial de tu Apellido:{Environment.NewLine}");

            //elementos del arreglo 2
            for (int i = 0; i < SegundoNombre.Length; i++)
            {
                Console.WriteLine(i + ".-" + SegundoNombre[i]);
            }
            Console.Read();
        }
    }
}
