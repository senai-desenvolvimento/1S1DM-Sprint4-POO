using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IngressoVip bilhete = new IngressoVip();
            bilhete.Valor = 20f;
            bilhete.ValorAdicional = 15.50f;
            bilhete.ImprimirValor();
            bilhete.MostrarValorVip();

            System.Console.WriteLine($"A diferença entre os valores é de R$ {bilhete.ValorAdicional}");
        }
    }
}
