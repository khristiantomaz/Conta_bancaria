

using System.Globalization;
using System;

namespace programa
{
    public class Conta
    {
       private int Numero { get; private set; }
       private string Titular { get; set; }

       private double Saldo {get; private set; }

       public Conta (int numero, string titular){

        Numero = numero;
        Titular = titular;
       }

       public Conta (int numero, string titular, double saldo) : this(numero, titular){

        Saldo = saldo;
       }

       public void deposito (double quantia ){

        Saldo += quantia;
       }

       public void Saque(double quantia){

        Saldo -= quantia +5.0;
       }

        public override string ToString()
        {
            return "Conta "
            + Numero 
            + "Tilular: "
            + Titular
            + ", saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }






    }
}