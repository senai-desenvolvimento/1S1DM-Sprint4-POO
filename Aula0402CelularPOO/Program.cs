using System;

namespace Aula0402CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Celular xiaomi  = new Celular();

            xiaomi.modelo   = "Xiaomi CC9";
            xiaomi.cor      = "Preto";
            
            Console.WriteLine("Deseja ligar o celular?");
            xiaomi.ligado   = Boolean.Parse(Console.ReadLine());

            if(xiaomi.ligado){
                
                while(xiaomi.ligado == true){

                    Console.WriteLine("O que deseja fazer? \n 1-Ligar \n 2-EnviarMensagem \n 3-Desligar");
                    int resposta = Int32.Parse( Console.ReadLine() );

                    switch (resposta)
                    {                    
                        case 1:
                        Console.WriteLine( xiaomi.FazerLigacao() );
                        break;

                        case 2:
                        Console.WriteLine( xiaomi.EnviarMensagem() );
                        break;

                        case 3:
                        Console.WriteLine( xiaomi.Desligar() );
                        break;

                        default:
                        Console.WriteLine(xiaomi.Ligar());
                        break;
                    }
                }
                
                
            }else{
                Console.WriteLine("Celular desligado");
            }

        }
    }
}
