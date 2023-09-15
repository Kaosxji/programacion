using System;

namespace CuentaBancaria
{
    class CuentaBancaria
    {
        private int pin;
        private int saldo;

        public int GetPin()
        {
            return pin;
        }

        public void SetPin(int nuevoPin)
        {
            if (PinValido(nuevoPin))
            {
                pin = nuevoPin;
            }
            else
            {
                Console.WriteLine("El nuevo PIN no es válido.");
            }
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(int nuevoSaldo)
        {
            if (nuevoSaldo >= 0)
            {
                saldo = nuevoSaldo;
            }
            else
            {
                Console.WriteLine("El saldo no puede ser negativo.");
            }
        }
        public CuentaBancaria(int pin)
        {
            if (PinValido(pin))
            {
                this.pin = pin;
            }
            else
            {
                Console.WriteLine("El PIN inicial no es válido.");
            }
        }

        private bool PinValido(int pin)
        {
            return true;
        }
    }

}

