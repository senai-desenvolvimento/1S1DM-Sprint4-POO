namespace Aula10Polimorfismo
{
    public class Player
    {
        public virtual void Pular(){
            System.Console.WriteLine("Pulando normalmente");
        }

        public virtual void Correr(){
            System.Console.WriteLine("Correndo normalmente");
        }

    }
}