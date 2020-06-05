namespace Aula11Polimorfismo
{
    public class Calculo
    {
        
        public string Calcular(){
            return "A vida do player não precisa ser calculada";
        }

        public string Calcular(int vida){
            return "A vida atual do player é" + vida;
        }

        public string Calcular(int vida, int escudo){
            return "A vida do player com escudo é"+ (vida+escudo);
        }

        public string Calcular(string nome, string sobrenome){
            return $"O nome do player completo é {nome} {sobrenome} ";
        }      

    }
}