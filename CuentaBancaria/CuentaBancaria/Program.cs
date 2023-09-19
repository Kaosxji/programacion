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
            cuenta.setPin(0);
            Console.WriteLine(" el Pin es " + cuenta.getPin());

            cuenta.setSaldo(1019);
            Console.WriteLine(" Tu saldo actaul es " +  cuenta.getSaldo());
            Console.ReadLine();

        }

    }
}

