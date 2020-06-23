using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Criamos uma lista de produtos
            List<Produto> produtos = new List<Produto>();

            // Criamos um produto simples
            Produto celular1 = new Produto();
            celular1.Codigo = 1;
            celular1.Nome = "Iphone X";
            celular1.Preco = 4000.99f;

            // Adicionamos um produto na lista criada
            produtos.Add(celular1);

            // Adicionamos mais produtos:
            produtos.Add( new Produto(2, "Galaxy", 2500.98f) );
            produtos.Add( new Produto(3, "Xiaomi", 2500.98f) );
            produtos.Add( new Produto(4, "Asus", 2500.98f) );
            produtos.Add( new Produto(5, "Lenovo", 2500.98f) );
            produtos.Add( new Produto(6, "Asus", 2500.98f) );

            // Varremos nossa lista com laço foreach
            foreach(Produto p in produtos)
            {   
                Console.ForegroundColor = ConsoleColor.Green;              
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            // Remove um item em específico
            produtos.Remove(celular1);

            // Remove através de um índice
            produtos.RemoveAt(1);

            // Removemos utilizando expressão Lambda
            produtos.RemoveAll( p => p.Nome == "Asus" );

            // Varremos nossa lista com laço foreach
            foreach(Produto p in produtos)
            {   
                Console.ForegroundColor = ConsoleColor.Red;             
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            // Procuramos um produto específico
            Produto lenovo = produtos.Find(x => x.Nome == "Xiaomi");
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( lenovo.Preco );
            Console.ResetColor();

            // Atividade seguirá à partir daqui:

        }
    }
}
