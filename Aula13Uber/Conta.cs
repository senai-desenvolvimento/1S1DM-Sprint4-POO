namespace Aula13Uber
{
    public class Conta
    {
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }

        /// <summary>
        /// Cadastra uma nova conta
        /// </summary>
        /// <returns>Mensagem de sucesso</returns>
        public string Cadastrar(){
            
            System.Console.WriteLine("Digite a agência");
            Agencia = System.Console.ReadLine();

            System.Console.WriteLine("Digite a conta corrente");
            ContaCorrente = System.Console.ReadLine();

            return "Dados da Conta Cadastrados";

        }

        /// <summary>
        /// Zera as variáveis da Conta
        /// </summary>
        public void Excluir(){
            Agencia = "";
            ContaCorrente = "";
        }

    }
}