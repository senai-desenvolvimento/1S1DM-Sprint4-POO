namespace Aula20_21_Exercicio
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public Restaurante(string _nome){
            this.NomeRestaurante = _nome;
        }

        public string MostrarDados(){
            return $"Restaurante: {NomeRestaurante} \nEndereco: {Endereco} \n\n";
        }
    }
}