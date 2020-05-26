using System;

namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno hitoshi = new Aluno();
            hitoshi.nome = "Hitoshi";
            hitoshi.idade = 16;
            hitoshi.bolsista = false;
            hitoshi.valorMensalidade = 2000f;
            hitoshi.mediaFinal = 9.7f;

            Console.WriteLine("Hitoshi: "+hitoshi.VerMediaFinal());
            Console.WriteLine("Hitoshi: "+hitoshi.VerMensalidade());

            Aluno ryan = new Aluno();
            ryan.nome = "Ryan";
            ryan.idade = 16;

            // Captura as informações do Console
            Console.WriteLine("Aluno bolsista?");
            ryan.bolsista = ryan.TraduzConsole(Console.ReadLine());

            ryan.valorMensalidade = 2000f;
            ryan.percentual = 40;
            ryan.mediaFinal = 8.7f;

            Console.WriteLine("Ryan: "+ryan.VerMediaFinal());
            Console.WriteLine("Ryan: "+ryan.VerMensalidade());

        }
    }
}
