using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {

        }

        public void MetodoPublico()
        {
            //Visivel fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            //Visivel apenas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            //Visivel apenas na classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            //Visivel apenas dentro do projeto onde foi criado.

            //como se fosse publico dentro do projeto onde ofi criado, mas para os demais projetos da solução 
            //ele fica privado e inacessível.
        }
    }
}
