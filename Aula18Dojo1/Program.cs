using System;

namespace Aula18Dojo1
{
    // 
    //
    //Pq está dando erro aqui?
    //
    class Program
    {
        static void Main(string[] args)
        {

            Jogador cr7 = new Jogador();
            cr7.Nome = "Cristiano Ronaldo";
            cr7.Posicao = "Atacante";
            cr7.Nascimento = DateTime.Parse("05/02/1985");            

            cr7.MostrarDados();
            Console.WriteLine( cr7.CalcularIdade() );
            Console.WriteLine( cr7.CalcularAposentadoria() );

        }
    }
}
