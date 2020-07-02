using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 2;
            p1.Nome = "Gianini5";
            p1.Preco = 5500f;

            p1.Cadastrar(p1);

            Produto alterado = new Produto();
            alterado.Codigo = 3;
            alterado.Nome = "Ibanez";
            alterado.Preco = 6800f;

            p1.Alterar(alterado);

            p1.Remover("Gianini5");

            List<Produto> lista = p1.Ler();

            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }

        }
    }
}
