namespace CelularPOO
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        /// <summary>
        /// Liga o celular
        /// </summary>
        /// <returns>altera o estado do celular e retorna um texto</returns>
        public string Ligar(){
            ligado = true;
            return "Ligando celular";
        }

        /// <summary>
        /// Desliga o celular
        /// </summary>
        /// <returns>altera o estado do celular e retorna um texto</returns>
        public string Desligar(){
            ligado = false;
            return "Desligando celular";
        }

        /// <summary>
        /// Envia mensagem
        /// </summary>
        /// <returns>retorna texto de mensagem enviada</returns>
        public string EnviarMensagem(){
            return "Enviando mensagem";
        }

        /// <summary>
        /// Realiza ligação
        /// </summary>
        /// <returns>retorna texto de ligação sendo realizada</returns>
        public string FazerLigacao(){
            return "Ligando para contato";
        }


    }
}