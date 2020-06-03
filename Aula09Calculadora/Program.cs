using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculadoraCientifica calc = new CalculadoraCientifica();
            Console.WriteLine("Faça um cálculo abaixo \n Utilize: \n + para soma, - para subtração, x para multiplicação e / para divisão");
            string calculo = Console.ReadLine();
            calc.ManipularCalculos(calculo);
            Console.WriteLine("Resultado: "+ calc.resultado);

            calc.resultado = 0;

            System.Console.WriteLine("Digite números separados por vírgula:");
            calc.CalcularMedia( Console.ReadLine() );
            System.Console.WriteLine("Média: "+calc.resultado);

        }
    }
}
