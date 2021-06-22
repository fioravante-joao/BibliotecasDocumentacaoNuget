using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using ICSharpCode.SharpZipLib;
namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //  pagina?argumentos
            //  012345678

            ExtratorValorDeArgumentosURL extratorValorDeArgumentosURL = new ExtratorValorDeArgumentosURL("http://autodoc.com.br/login?nome=joao&senha=1234");

            
            Console.ReadLine();

            string textoVazio = "";
            string textoNull = null;
            string textoQualquer = "dfghjk";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNull));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));

            Console.ReadLine();

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);            
            string argumentos = url.Substring(indiceInterrogacao+1);
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }
}
