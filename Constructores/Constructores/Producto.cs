using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Producto
    {
        private float precio;
   

        public Producto (float valProducto) 
        {
            precio = valProducto;
        }

        public float calcPrecio()
        {
            float total = precio * 1.16f;
            return total;
        }

    }
}
