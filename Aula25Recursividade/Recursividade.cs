using System;

namespace Aula25Recursividade
{
    public class Recursividade
    {

        // 0 , 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584
        public void GerarSequenciaFibonacci(int num1, int num2, int vezes){

            // Sempre precisamos de uma condição de parada
            if(vezes > 0){
                Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }
        }

        // 5! = 5 x 4 x 3 x 2 x 1
        public int GerarFatorial(int numero){

            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero -1);
            }
        }
        
    }
}