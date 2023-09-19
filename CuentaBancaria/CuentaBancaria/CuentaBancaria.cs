using System;

class CuentaBancaria
{
    private int pin;
    private int saldo;

    public int getPin()
    {
        return pin;
    }
    public void setPin (int valor)
    {
        pin = valor;
    }
    public int getSaldo()
    {
        if (pin != 0)
        {
            return saldo;
        }
        else
        {
            Console.WriteLine(" No se puede consultar el saldo ingrese un PIN valido porfavor ");
            return 0;
        }

    }

    public void setSaldo (int cifra )
    {
        saldo = cifra;
      
    }
}

