using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    
    class Triangulo
    {
        private float lado1 = 10;
        private float lado2 = 5;
        private float lado3 = 5;

        public Triangulo() 
        {
        }
        public Triangulo(float valLado1, float valLado2, float valLado3) 
        {
            lado1 = valLado1;
            lado2 = valLado2;
            lado3 = valLado3;
        }

        public void describir()
        {
            Console.WriteLine("Triangulo " + lado1  + "+" + lado2 + "+" + lado3 );
        }
         public float calcPerimetro()
        {
            float perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }


    }
}
