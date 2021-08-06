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
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(244);
            idades.AdicionarVarios(244,234,456,432,765);


            for (int i = 0; i < idades.Tamanho; i++)
            {
                Console.WriteLine("for laço");
                int idadeAtual = idades[i];
                Console.WriteLine(idadeAtual);
            }

            Console.WriteLine($" Tamanho {idades.Tamanho}");


            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(5);
            listaDeIdades.AdicionarVarios(5, 6, 8, 10);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"idade no indice {i}: {idade}");
            }
        }
        static void testaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaJoao = new ContaCorrente(123, 123456);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaJoao,
                new ContaCorrente(123, 3898765),
                new ContaCorrente(123, 1234567)
            };

            lista.AdicionarVarios(contas);

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posicao {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }
        static void testaArrayDeContaCorrente()
        {
            //inicializador de array's
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(123, 12343455),
                new ContaCorrente(123, 87654322),
                new ContaCorrente(123, 56754327)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }
        static void testaArrayInt()
        {
            //array de inteiros, com 5 posições!
            int[] idades = new int[6];

            idades[0] = 23;
            idades[1] = 18;
            idades[2] = 12;
            idades[3] = 60;
            idades[4] = 26;
            idades[5] = 36;

            Console.WriteLine(idades.Length);

            int acumulador = 0;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine($"Media de idades = {media}");
        }
    }
}
