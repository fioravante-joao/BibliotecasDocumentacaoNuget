using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Aula : IComparable
    {
        public string Titulo { get; set; }
        public int Tempo { get; set; }

        public Aula(string titulo, int tempo)
        {
            this.Titulo = titulo;
            this.Tempo = tempo;
        }

        public override string ToString()
        {
            return $"[titulo: {Titulo}, tempo: {Tempo} minutos]";
        }

        //abaixo implementação do método CompareTo  
        public int CompareTo(object obj)
        {
            var outraAula = obj as Aula;

            if (outraAula == null)
            {
                return -1;
            }

            if (Tempo < outraAula.Tempo)
            {
                return -1;
            }

            if (Tempo == outraAula.Tempo)
            {
                return 0;
            }

            return 1;
        }
    }
}
