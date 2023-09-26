﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se construye con valores predeterminados
            Rectangulo rect1 = new Rectangulo();
            rect1.describir();
            float area1 = rect1.calcArea();
            Console.WriteLine("Area=" + area1);
            //
            Rectangulo rect2 = new Rectangulo();
            rect2.setAlto(12);
            rect1.describir();
            float area2 = rect2.calcArea();
            Console.WriteLine("Area=" + area2);

            //construllo un rectangulo definiendoi los valores desde el constructor
            Rectangulo rect3 = new Rectangulo(3,2);
            rect3.describir();
            float area3 = rect3.calcArea();
            Console.WriteLine("Area=" + area3);

            Triangulo trian1 = new Triangulo(16, 10, 12);
            trian1.describir();
            float perimetro1 = trian1.calcPerimetro();
            Console.WriteLine("Perimetro " + perimetro1);

            Triangulo trian2 = new Triangulo();
            trian2.describir();
            float perimetro2 = trian2.calcPerimetro();
            Console.WriteLine("Perimetro " + perimetro2);

            Circulo circ1 = new Circulo();


            Console.ReadLine();
        }
    }
}
