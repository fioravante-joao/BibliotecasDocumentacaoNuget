﻿using System;
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
            DateTime dataFimPagamento = new DateTime(2021, 08, 17);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = TimeSpan.FromMinutes(40);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            //ContaCorrente conta = new ContaCorrente(1234,123400);
            //ContaCorrente conta2 = new ContaCorrente(2222,332220);
            //conta.Transferir(200,conta2);

            Console.ReadLine();
        }
    }
}
