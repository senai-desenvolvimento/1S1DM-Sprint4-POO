using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância com o método construtor sem argumentos
            Produto sapato = new Produto();

            // Instância da sobrecarga do método construtor com 1 argumento
            Produto chinelo = new Produto(789);
            System.Console.WriteLine(chinelo.Codigo);


            System.Console.WriteLine();

            // Instância com todos os atributos
            Produto tenis = new Produto(678, "All Star", "Couro", 45);
            System.Console.WriteLine(tenis.Codigo);
            System.Console.WriteLine(tenis.Nome);
            System.Console.WriteLine(tenis.Descricao);
            System.Console.WriteLine(tenis.Estoque);



        }
    }
}
