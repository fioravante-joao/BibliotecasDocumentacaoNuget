using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    class ComparadorNomeAula : IComparer<Aula>
    {
        public int Compare(Aula x, Aula y)
        {
            //if (x.Titulo < y.Titulo)
            //{
            //    return -1;  //x fica na frente de y
            //}

            //if (x.Titulo == y.Titulo)
            //{
            //    return 0; // são equivalentes
            //}

            //return 1;

            if (x == y)
            {
                return 0;
            }

            if (x.Titulo == null)
            {
                return 1;
            }

            if (y.Titulo == null)
            {
                return -1;
            }

            return x.Titulo.CompareTo(y.Titulo);  //essa linha faz a mesma coisa que os if's comentados nas linhas acima.


        }
    }
}
