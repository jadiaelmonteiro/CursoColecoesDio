using System;

namespace ExemploColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando array
            int[] arrayInteiros = new int[3];

            
            //atribuindo valores
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            Console.WriteLine("Percorrendo o array pelo for.");
            //estrutura de loop, para imprimir o array em console
            for (int i = 0; i < arrayInteiros.Length; i++) //Length retorna o número máximo de um array
            {
                Console.WriteLine(arrayInteiros[i]);
            }

            Console.WriteLine("Percorrendo o array pelo foreach.");
            //estrutura de repitção guarda o array na variavel 
            foreach (int item in arrayInteiros)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
