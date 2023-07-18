using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace programa
{
 
  class Banco
  {
    static void Main(string[] args){

  
   System.Console.Write("Entre o numero da sua conta: ");
   int numero = int.Parse(System.Console.ReadLine());
   System.Console.Write("Entre o titular da conta: ");
   string titular= System.Console.ReadLine();
   System.Console.Write("Haverá deposito inicial ? (s/n)?");
   char resp = char.Parse(System.Console.ReadLine());
   if (resp == 's' || resp == 'S'){

    System.Console.Write("Entre com o valor do deposito: ");
    double deposito = double.Parse(System.Console.ReadLine());

   }
   
   
   
   }
    
  }

}