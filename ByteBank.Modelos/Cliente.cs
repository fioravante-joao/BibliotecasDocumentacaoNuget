using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Classe Cliente
    /// </summary>
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>retorna um booleano</returns>
        public override bool Equals(object obj)
        {
            //Cliente outroCliente = (Cliente)obj; com cast convertendo o obj para Cliente
            Cliente outroCliente = obj as Cliente;   //usando alias para saber se o OutroCliente é nullo  aqui a variavel outroCliente espera um obj do tipo Cliente, e como o obj passado foi do tipo ContaCOrrente, a operação é false.

            if (outroCliente == null)
            {
                return false;
            }

            return CPF == outroCliente.CPF;
        }
    }
}
