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
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(123); //número da agencia
                escritor.Write(11234); //Numero Conta
                escritor.Write(4000.00); //Saldo
                escritor.Write("Nelson Mandela"); //nome
            }
        }

        static void LeituraBinario()
        {
            var arquivo = "ContaCorrente.txt";

            using (var fs = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new BinaryReader(fs))  // Encoding.UTF8 |esse parametro pode ser inserido no método BinaryReader
            {
                var ag = leitor.ReadInt32();
                var cc = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Titular: {titular}, Conta: {cc}, Agencia: {ag}, Saldo: {saldo}");
            }
        }

        static void Cria2txtcomESemBinario()
        {
            var numero = 691693903;

            //Cria o arquivo txt com o valor da varialvel acima em binário
            using (var fs = new FileStream("BinaryWriter.txt", FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(numero);
            }

            //Cria o arquivo txt com o valor da varialvel acima com string literal
            using (var fs = new FileStream("StreamWriter.txt", FileMode.Create))
            using (var writer = new StreamWriter(fs))
            {
                writer.Write(numero);
            }
        }
    }
}