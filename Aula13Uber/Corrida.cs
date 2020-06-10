namespace Aula13Uber
{
    public class Corrida
    {
        public string LocalInicio { get; set; }
        public string LocalChegada { get; set; }
        public string StatusCorrida { get; set; }
        public string motorista { get; set; }
        public string passageiro { get; set; }

        /// <summary>
        /// Cancela a corrida
        /// </summary>
        /// <returns>Texto de aviso de cancelamento</returns>
        public string Cancelar(){
            StatusCorrida = "Cancelada";
            return "Corrida Cancelada";
        }
    }
}