namespace CadastroAluno
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public string rg;
        public bool bolsista;
        public float percentual;
        public float mediaFinal;
        public float valorMensalidade;

        /// <summary>
        /// Mostra média final do aluno
        /// </summary>
        /// <returns>O valor da média final(float)</returns>
        public float VerMediaFinal(){
            return mediaFinal;
        }

        /// <summary>
        /// Calcula e mostra o valor da mensalidade do aluno
        /// </summary>
        /// <returns>Valor calculado da mensalidade (float)</returns>
        public float VerMensalidade(){

            float valorCalculado = valorMensalidade;

            if(bolsista == true){
                valorCalculado = valorMensalidade - (valorMensalidade * percentual /100);
            }

            return valorCalculado;
        }

        /// <summary>
        /// Traduz tipo de resposta do console para booleana
        /// </summary>
        /// <param name="condicao">texto capturado pelo console</param>
        /// <returns>Retorna se é bolsista ou não</returns>
        public bool TraduzConsole(string condicao){
            if(condicao == "sim"){
                bolsista = true;
            }else{
                bolsista = false;
            }
            return bolsista;
        }

    }
}