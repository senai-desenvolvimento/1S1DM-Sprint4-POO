using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            
            Conversor.CotacaoDolar = 5.29f;
            Console.WriteLine( Conversor.ConverterDolarParaReal(23) );
            Console.WriteLine( Conversor.ConverterRealParaDolar(200.25f) );

            Console.ResetColor();

        }
    }
}
