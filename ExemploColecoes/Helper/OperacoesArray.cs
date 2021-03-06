using System;

namespace ExemploColecoes.Helper
{
    class OperacoesArray
    {
        //Metodo para ordernar o array
        public void OrdenarBubbleSort(ref int [] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        //Metodo p imprimir o array em console
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);            
            Console.WriteLine(linha);
            
        }
        
        //Metodo p redimencionar o array.
        public void RedimencionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        //Metodo p converter um array
        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}
