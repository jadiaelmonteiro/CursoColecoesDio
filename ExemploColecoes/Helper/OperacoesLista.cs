using System;
using System.Collections.Generic;

namespace ExemploColecoes.Helper
{
    class OperacoesLista
    {

        //Metodo retorna void, para imprimir lista
        public void ImprimirListaString(List<string> lista)
        {
            //imprimindo usando o for
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Indice {i} valor: " + lista[i]);
            }

        }
    }
}
