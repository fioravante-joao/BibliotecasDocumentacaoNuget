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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "123,234567,1232.00, Matusalem de Salém";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            try
            {
                using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
                using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
                {
                    escritor.Write("123,34567,1234.00, Matusalém de Salém");
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Já existe um arquivo como este cadastrado! \n Precione o Enter para tentar novamente.");
                //throw; apenas se quiser exibir a mensagem automatica sobre a exceprtion gerada.
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                for (int i = 0; i < 10000000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); //Despeja o Buffer para o Stream!     faz com que a iformação seja gravada no arquivo dentro do hd imediatamente

                    Console.WriteLine($"Linha {i}, foi escrita no arquivo. tecle enter para prosseguir!");
                    Console.ReadLine();
                }

                
            }
        }
    }
}