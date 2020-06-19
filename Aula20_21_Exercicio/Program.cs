using System;

namespace Aula20_21_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente nicolas = new Cliente("Nicolas");
            nicolas.Endereco = "Av Brasil, 123";
            Console.WriteLine( nicolas.MostrarDados() );

            Restaurante bk = new Restaurante("Burguer King");
            bk.Endereco = "Av Paulista, 123";
            Console.WriteLine( bk.MostrarDados() );

            Pedido pedido1 = new Pedido();
            pedido1.Cliente     = nicolas;
            pedido1.Restaurante = bk;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Digite um item");
                pedido1.Itens[i] = Console.ReadLine();
            }

            Console.WriteLine( pedido1.EntregarPedido() ); 

        }
    }
}
