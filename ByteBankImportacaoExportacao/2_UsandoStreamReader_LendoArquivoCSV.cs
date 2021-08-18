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
        static void LendoArquivoCSV()
        {
            var enderecoDoArquivo = "Contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo, Encoding.UTF8))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"Títular {contaCorrente.Titular.Nome}: Conta número {contaCorrente.Numero}, Ag. {contaCorrente.Agencia}, Saldo: {contaCorrente.Saldo}";
                    Console.WriteLine(msg);
                    //Console.WriteLine(linha);
                }
            }

            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            //linha abaixo cria um array de string e recebe o parametro linha separando cada valor por espaço
            string[] campos = linha.Split(',');

            var agencia = campos[0]; //resgata o primeiro valor
            var numero = campos[1]; //resgata o segundo valor
            var saldo = campos[2].Replace('.', ','); //resgata o terceiro valor
            var nomeTitular = campos[3]; //resgata o quarto valor

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}