using System;

namespace CSharp
{
   class Program
   {
       static void Main(string[] args)
       {
          ContaCorrente CC = new ContaCorrente("Ana", 22, 22);
          ContaCorrente CC1 = new ContaCorrente("Joao", 12, 12);
          ContaCorrente CC2 = new ContaCorrente("Bruno", 42, 22);

          CC.deposita(300);
          CC.saca(200);          
       }
   } 
}