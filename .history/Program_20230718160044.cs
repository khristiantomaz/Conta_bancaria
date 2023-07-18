using System;
using System.Globalization;


namespace programa
{

  class Banco
  {
    static void Main(string[] args)
    {

      ContaBancaria conta;


      System.Console.Write("Entre o numero da sua conta: ");
      int numero = int.Parse(System.Console.ReadLine());
      System.Console.Write("Entre o titular da conta: ");
      string titular = System.Console.ReadLine();
      System.Console.Write("Haverá deposito inicial ? (s/n)?");
      char resp = char.Parse(System.Console.ReadLine());
      if (resp == 's' || resp == 'S')
      {

        System.Console.Write("Entre com o valor do deposito: ");
        double depositoInicial = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
        conta = new ContaBancaria(numero, titular, depositoInicial);
      }
      else
      {
        conta = new ContaBancaria(numero, titular);
      }
      Console.WriteLine();
      Console.WriteLine("Dados da conta:");
      Console.WriteLine(conta);

      Console.WriteLine();
      Console.Write("Entre um valor para depósito: ");
      double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.Deposito(quantia);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(conta);

      Console.WriteLine();
      Console.Write("Entre um valor para saque: ");
      quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.Saque(quantia);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(conta);


    }

  }

}

