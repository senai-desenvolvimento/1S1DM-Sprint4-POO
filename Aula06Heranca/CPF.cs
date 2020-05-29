namespace Aula06Heranca
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(){
           
           if(cpf != ""){
               return true;
           }

           return false;
        }
    }
}