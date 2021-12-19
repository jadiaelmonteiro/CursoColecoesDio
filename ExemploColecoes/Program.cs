using ExemploColecoes.Helper;
using System;

namespace ExemploColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 8, 1, 9};
            Console.WriteLine("Array original");
            op.ImprimirArray(array);
           
            op.OrdenarBubbleSort(ref array);
            Console.WriteLine("Array ordenado");
            op.ImprimirArray(array);
            Console.WriteLine();



            Console.WriteLine("Matriz");
            //declarando uma matriz já com os dados do array
            int[,] matriz = new int[4, 2] 
            {
                { 8, 8 },
                {10, 20 },
                {50, 100 },
                {90, 200 }
            };

            // laço para linhas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                //laço para as colunas
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
            


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
