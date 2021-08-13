using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {

        //metodo de extensão que posso usar com qualquer list de qualquer tipo.
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.AdicionarVarios<int>(122, 122, 122);  //basta indicar o tipo após a chamada do metodo como é feito aqui <int>
        }
    }
}
