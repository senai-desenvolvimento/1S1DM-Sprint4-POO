using System;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Gibson";
            p1.Preco = 5500f;

            p1.Cadastrar(p1);
        }
    }
}
