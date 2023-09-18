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
            CuentaBancaria cuenta = new CuentaBancaria(1234, 1000.00)
            {

                Pin = 4321,
                Saldo = 896,
            };
            cuenta.Pin = 58;
            int saldoActual = cuenta.Saldo;

            cuenta.Pin = 1234;
            saldoActual = cuenta.Saldo;
            Console.WriteLine($"Saldo actual: {saldoActual}");

            Console.ReadLine();
        }
    }

}

