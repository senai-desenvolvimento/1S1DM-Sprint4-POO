namespace Aula06Heranca
{
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool ValidarCNPJ(){

            if(cnpj != ""){
                return true;
            }

            return false;
        }
    }
}