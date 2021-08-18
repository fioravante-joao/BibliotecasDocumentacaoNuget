using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // == imput  e  output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "Contas.txt";  //arquivo CSV que será lido


            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];  //1kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"\n bytes lidos: {numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

                //ao utilizar o bloco using no final da execução ele mesmo chama o Disposing que por sua vez chama o close.
                //fluxoDoArquivo.Close();  //método que indica ao sistema operacional que eu liberei o arquivo.
            }
        }
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
}