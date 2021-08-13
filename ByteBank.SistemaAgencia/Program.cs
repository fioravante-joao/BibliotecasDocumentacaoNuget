using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>() //cria a variavel e já inicializa ela com a lista, e abaixo já preenche a lista
            {
                //inicializador da lista<ContaCorrente>
                new ContaCorrente(132,999999),
                new ContaCorrente(932,765432),
                null,
                new ContaCorrente(532,822288)
            };

            //contas.Sort();

            //contas.Sort(new ComparadorContaCorrentePorAgencia());
                        
            var contasOrdernadas = contas    //lib/dll linq com expressões lambda 
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdernadas)
            {
                Console.WriteLine($"Conta: {conta.Numero}, Agencia: {conta.Agencia}");  
            }









            //var aulas = new List<Aula>()
            //{
            //    new Aula("Wendor", 1),
            //    new Aula("Métodos e propriedades", 35),
            //    new Aula("Expressões regulares", 29),
            //    new Aula("Classe object", 45)
            //    //new Aula(null,0) //teste passando titulo como nullo.
            //};

            ////aulas.Sort(); // metodo compareTO implementado na classe Aula permite a comparação por Tempo

            ////metodo compare implementado na classe ComparadorNomeAula permite a comparação por Tempo e por Título
            //aulas.Sort(new ComparadorNomeAula());

            //Imprimir(aulas);


            Console.ReadLine();
        }

        static void Imprimir(List<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
        static void testaSort()
        {
            var nomes = new List<string>()  //cria a varriavel e já inicializa ela com a lista  e abaixo já preenche a lista
            {
                //inicializador de listas
                "Amom",
                "Negron",
                "Juiron",
                "Wandon"
            };

            nomes.AdicionarVarios("A", "Ana", "Maria");

            nomes.Sort();

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }


            var idades = new List<int>();

            idades.Add(2);
            idades.Add(22);
            idades.Add(23);
            idades.Add(24);

            idades.AdicionarVarios(1, 3, 4, 6, 8);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
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
