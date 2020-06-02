using System;

namespace Aula08abstracao
{
    public class Pagamento
    {

        // Get = permissão de leitura da variável
        // Set = permissão de escrita da variável

        public DateTime data { get; set; }
        public float valor { get; set; } 

        public string Pagar(){
            return "Pagamento efetuado";
        }

        public string CancelarPagamento(){
            return "Pagamento cancelado";
        }

    }
}