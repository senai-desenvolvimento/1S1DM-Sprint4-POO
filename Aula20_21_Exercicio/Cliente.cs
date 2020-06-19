namespace Aula20_21_Exercicio
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }

        public Cliente(string _nome){
            this.NomeCliente = _nome;
        }

        public string MostrarDados(){
            return $"Cliente: {NomeCliente} \nEndereco: {Endereco} \n\n";
        }

    }
}