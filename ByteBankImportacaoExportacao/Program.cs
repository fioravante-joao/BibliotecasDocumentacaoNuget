using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // == imput  e  output
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            //CriarArquivo();

            //CriarArquivoComWriter();
            //Console.WriteLine("Aplicação Finalizada! ! !");

            //CriandoCopiaArquivoCSV();

            //TestaEscrita();

            //EscritaBinaria();

            //LeituraBinario();

            //Cria2txtcomESemBinario();

            UsarStreamDeEntradaDaConsole();
            Console.WriteLine("Fim");

            Console.ReadLine();
        }
    }
}
