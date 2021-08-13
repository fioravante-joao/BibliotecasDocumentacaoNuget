using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDeExtensao
{
    public static class ListMetodoDeExtensao
    {
        public static void AdicionarVariosComArray(this List<int> listaInteiros, params int[] itens)
        {
            foreach (var item in itens)
            {
                listaInteiros.Add(item);
            }
        }
    }
}
