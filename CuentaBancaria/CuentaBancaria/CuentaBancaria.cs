using System;

class CuentaBancaria
{
    private int pin;
    private int saldo;

    public CuentaBancaria(int v1, double v2)
    {
        V1 = v1;
        V2 = v2;
    }

    public int Pin
    {
        get { return pin; }
        set { pin = value; }
    }

    public int Saldo
    {
        get
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
    }

    public int V1 { get; }
    public double V2 { get; }
}

