namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        public string Carro { get; set; }
        public string Placa { get; set; }

        /// <summary>
        /// Mostra um texto representando que o motorista aceitou o passageiro
        /// </summary>
        /// <param name="nome">Nome do passageiro</param>
        /// <returns>Um texto explicativo sobre a aceitação</returns>
        public string AceitarPassageiro( string nome ){
            // Usando variável local e variável da superclasse
            return $"Passageiro {nome} aceito pelo motorista {this.Nome}";
        }

        /// <summary>
        /// Recebe o pagamento caso a corrida esteja finalizada
        /// </summary>
        /// <param name="statusCorrida">Parâmetro requerido vindo da classe Corrida</param>
        /// <returns>Boleano, se recebeu ou não o pagamento</returns>
        public bool ReceberPagamento(string statusCorrida){
            if(statusCorrida == "Finalizada"){
                return true;
            }

            return false;
        }

    }
}