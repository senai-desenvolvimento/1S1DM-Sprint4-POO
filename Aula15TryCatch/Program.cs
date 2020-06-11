using System;
using System.IO;

namespace Aula15TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Permissao app = new Permissao();
            app.Autorizar();

            try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"A primeira linha desse arquivo é: \n {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"O arquivvo não foi encontrado");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"O diretório não foi encontrado");
            }
            catch (IOException)
            {
                Console.WriteLine($"O arqvuivo não pode ser aberto");
            }  

            
        }
    }
}
