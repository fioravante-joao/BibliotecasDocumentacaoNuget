using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDeExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.AdicionarVariosComArray(11, 22, 33, 44, 55, 66, 77, 88);

            idades.Remove(11);

            foreach (var item in idades)
            {
                Console.WriteLine($"Item ativo: {item}");
                Console.WriteLine("_______________|");
            }

            Console.ReadLine();
        }
    }
}
