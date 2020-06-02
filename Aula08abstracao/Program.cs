using System;

namespace Aula08abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            
            System.Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse( Console.ReadLine() );
            System.Console.WriteLine("Data digitada: "+visa.data);

        }
    }
}
