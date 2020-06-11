using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        
        private bool Acesso { get; set; }

        public void Autorizar(){

            
            try{

                Console.WriteLine("Acessar aplicação? True/False");
                Acesso = Boolean.Parse( Console.ReadLine() );

            }catch(Exception){

                Console.WriteLine("Erro nos dados inseridos, erro gerado");

            }


        }

    }
}