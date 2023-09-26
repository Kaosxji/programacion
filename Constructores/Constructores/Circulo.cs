using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Circulo
    {
        private float diametro = 30;
        private float Pi = 3.14f;

        public Circulo() 
        {
        }

        public Circulo(float valDiametro) 
        {
            diametro = valDiametro;
        }
        public void describir()
        {
            Console.WriteLine("Ciculo " + diametro + "x" + Pi);
        }
        public float calcPerimetro()
        {
            float peri = diametro * 3.14f; 
            return peri;
        }

    }
}
