using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Rectangulo
    {
        //Estos atributos llevan un valor por default
        private float ancho = 5;
        private float alto = 10;
        
        public Rectangulo() //este es un Constructor sin paraemtros
        {

        }
        public Rectangulo(float valorAncho, float valorAltura) 
        {//establezco el valor inicial del objeto 
            ancho = valorAncho;
            alto = valorAltura;
        }
        public void describir()
        {
            Console.WriteLine("rectangulo " + ancho + "x" + alto);
        }
        public float calcArea()
        {
            float area = alto * ancho;
            return area; //aqui termina el metodo.
        }
        //Set significa definir
        public void setAlto(float valor) 
        {
            alto = valor;
        }
    }
}
