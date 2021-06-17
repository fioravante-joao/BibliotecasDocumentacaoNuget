using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf)  //construtor passando informações para classe base "Funcionario"
            : base(salario, cpf)
        {
        }
        public override void AumentarSalario()
        {
            throw new NotImplementedException();  //código padrão para implementação do metodos;
        }

        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
            // Qualquer código para implementação do meu método;
        }
    }
}
