using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //ContaCorrente conta = new ContaCorrente(1223, 33456568);

            //Console.WriteLine(conta);

            //a implementação do metodos ToString foi alterada na classe ContaCorrente para devolver os valos contidos no Objeto e 
            //não o nome da classe onde o objeto se encontra .
            //var contaCorrenteToString = conta.ToString();
            //Console.WriteLine(contaCorrenteToString);


            //Implementação do método Equals com overrride na classe Cliente
            Cliente cliente1 = new Cliente();
            Cliente cliente2 = new Cliente();

            cliente1.Nome = "joao";
            cliente1.CPF = "123.123.123-22";
            cliente1.Profissao = "Developer";

            cliente2.Nome = "joao";
            cliente2.CPF = "123.123.123-22";
            cliente2.Profissao = "Developer";

            ContaCorrente conta2 = new ContaCorrente(1234,345677800);

            if (cliente1.Equals(cliente2))
            {
                Console.WriteLine("o Cliente1 é igual o cliente2");
            }
            else
            {
                Console.WriteLine("Não é igual");
            }





            Console.ReadLine();
        }

        static void codigo()
        {
            string padraoValidaCPF = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}";

            string cpf = "412.145.968-78";

            Match result = Regex.Match(cpf, padraoValidaCPF);
            Console.WriteLine(result.Value);

            Console.ReadLine();

            //string padrao1 = "Sala [A-G][-]?[0123456789]{2}";

            //// o método IsMatch retorna um booleano
            //Console.WriteLine(Regex.IsMatch("Sala G345", padrao1));
            //Console.WriteLine(Regex.IsMatch("Sala J-001", padrao1));
            //Console.WriteLine(Regex.IsMatch("Sala a004", padrao1));
            //Console.WriteLine(Regex.IsMatch("Sala C004", padrao1));
            //Console.WriteLine(Regex.IsMatch("Minha sala é a sala G34", padrao1));
            //Console.WriteLine(Regex.IsMatch("Minha sala é a Sala G-34", padrao1));

            //Console.ReadLine();

            //Recuperando numero de telefone com expressões regulares   ou   REGEX

            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";

            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";

            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";


            string textoDeTeste = "Meu nome é João, me ligue em 94860----3429";

            //o método Regex.Match   captura a string de acordo com a expressão regular.
            Match resultado = Regex.Match(textoDeTeste, padrao);
            if (resultado.Value == "")
            {
                Console.WriteLine("O padrão está inválido");
            }
            Console.WriteLine(resultado.Value);


            Console.ReadLine();




            //  pagina?argumentos
            //  012345678

            //ExtratorValorDeArgumentosURL extratorValorDeArgumentosURL = new ExtratorValorDeArgumentosURL("http://autodoc.com.br/login?nome=joao&senha=1234");


            //Console.ReadLine();

            string urlDeTeste = "https://google.com/?q=https://www.bytebank.com/cambio";
            int indiceByteBank = urlDeTeste.IndexOf("https://www.bytebank.com");

            //O metodo StartsWith retorna um boleano se a string começa com ....
            Console.WriteLine(urlDeTeste.StartsWith("https://www.bytebank.com"));
            //O metodo StartsWith retorna um boleano se a string termina com ....
            Console.WriteLine(urlDeTeste.EndsWith("cambio"));

            Console.WriteLine(urlDeTeste.Contains("bytebank"));


            Console.WriteLine(indiceByteBank == 0);

            Console.ReadLine();

            string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de Moeda Destino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de Moeda Origem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();

            //Testando o Replace 
            string mensagemOriginal = "PALAVRA";
            string textoBusca = "PALAVRA";

            textoBusca = textoBusca.Replace("PALAVRA", "palavrinhas"); //replace alterando string
            textoBusca = textoBusca.Replace('P', 'p'); // replace alterando char
            textoBusca = textoBusca.ToLower(); //  minusculas
            textoBusca = textoBusca.ToUpper(); //  maiúsculas

            Console.WriteLine(textoBusca);

            Console.ReadLine();

            //string textoVazio = "";
            //string textoNull = null;
            //string textoQualquer = "dfghjk";

            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNull));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));

            //Console.ReadLine();

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("https://autodoc.atlassian.net/secure/RapidBoard.jspa?rapidView=43&projectKey=DEV&selectedIssue=DEV-9484");

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogacao = url.IndexOf('?');

            //Console.WriteLine(indiceInterrogacao);

            //Console.WriteLine(url);            
            //string argumentos = url.Substring(indiceInterrogacao+1);
            //Console.WriteLine(argumentos);

            //string endereco = "https://autodoc.atlassian.net/secure/RapidBoard.jspa?rapidView=43&projectKey=DEV&selectedIssue=DEV-9484";

            //int interrogacao = endereco.IndexOf('?');

            //Console.WriteLine(interrogacao);

            //Console.WriteLine(endereco);
            //string capturaArgumentos = endereco.Substring(interrogacao + 1);
            //Console.WriteLine(capturaArgumentos);

            Console.ReadLine();
        }
    }
}
