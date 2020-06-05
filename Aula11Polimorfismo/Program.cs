using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculo infoPlayer = new Calculo();

            // Sem argumentos
            System.Console.WriteLine( infoPlayer.Calcular() );

            // Com 1 argumento int
            System.Console.WriteLine( infoPlayer.Calcular(100) );

            // Com 2 argumentos int
            System.Console.WriteLine( infoPlayer.Calcular(100, 40) );

            // Com 2 argumentos string
            System.Console.WriteLine( infoPlayer.Calcular("John", "Wick") );

        }
    }
}
