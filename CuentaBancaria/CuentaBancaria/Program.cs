using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();

            cuenta.Pin = 0;
            int saldoActual = cuenta.Saldo;

           
            cuenta.Pin = 1234;
            saldoActual = cuenta.Saldo;
            Console.WriteLine($"Saldo actual: {saldoActual}");

            Console.ReadLine();
        }
        
    }
}

