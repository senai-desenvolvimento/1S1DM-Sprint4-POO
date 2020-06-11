using System;

namespace Aula13Uber
{
    public class Cartao
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public string Bandeira { get; set; }
        public string Cvv { get; set; }

        /// <summary>
        /// Salva os dados do Cartão
        /// </summary>
        /// <returns></returns>
        public string Cadastrar(){

            Console.WriteLine("Digite o nome do titular do cartão:");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o número do cartão:");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite a bandeira do cartão:");
            Bandeira = Console.ReadLine();
            
            Console.WriteLine("Digite o código de segurança do cartão:");
            Cvv = Console.ReadLine();

            return "Cartao cadastrado com sucesso!";
        }

        /// <summary>
        /// Apaga os dados instanciados do cartão
        /// </summary>
        public void Excluir(){
            Titular = "";
            Numero = "";
            Bandeira = "";
            Cvv = "";
        }
    }
}