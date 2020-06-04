namespace Aula10Polimorfismo
{
    public class Luigi : Player
    {
        public override void Pular(){

            // Manter as ações do método pai
            base.Pular();

            // Acrescento novas ações
            System.Console.WriteLine("Luigi agora está pulando com uma altura 30% mais alta");

        }
    }
}