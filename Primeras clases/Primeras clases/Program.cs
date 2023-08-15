using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeras_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //punto de inicio o de entrada de mi programa
            //Tipo           Nombre      inicializacion
            DispositivoMovil miIphone = new DispositivoMovil();
            miIphone.almacenamiento = 64;
            miIphone.ram = 16;
            miIphone.resoluAlto = 1080;
            miIphone.resoluAncho = 1920;
            miIphone.color = new Color();
            miIphone.color.azul = 120;
            miIphone.color.verde = 20;
            miIphone.color.rojo = 210;

            DispositivoMovil tabletSamsung = new DispositivoMovil();
            tabletSamsung.almacenamiento = 256;
            tabletSamsung.ram = 8;
            tabletSamsung.resoluAlto = 1080;
            tabletSamsung.resoluAncho = 1920;

            DispositivoMovil HuaweiY9 = new DispositivoMovil();
            HuaweiY9.almacenamiento = 120;
            HuaweiY9.ram = 16;
            HuaweiY9.resoluAlto = 1080;
            HuaweiY9.resoluAncho = 1920;
            HuaweiY9.color.azul = 1;


         
        }
    }
}
