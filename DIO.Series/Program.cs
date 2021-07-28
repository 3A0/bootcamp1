﻿using DIO.Series.Classes;
using DIO.Series.Enum;
using System;

namespace DIO.Series
{
    public class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        //InserirSerie();
                        break;
                    case "3":
                        //AtualizarSerie();
                        break;
                    case "4":
                        //ExcluirSerie();
                        break;
                    case "5":
                        //VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Count== 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach ( var serie in lista)
            {
                Console.WriteLine("#ID {0}: {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");
            //https://docs.microsoft.com/pt.br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            //https://docs.microsoft.com/pt.br/dotnet/api/system.enum.getname?view=netcore-3.1
            
            var a = enum.GetValues(typeof(Genero));
            foreach (var i in enum.GetValues(typeof(Genero)) )
            {
                Console.WriteLine("{0} .{1}", i, enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine));

            Console.Write("Digite a Descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series a seu dispor!");
            Console.WriteLine("Informea opção desejada");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("6- Limpar tela");
            Console.WriteLine("X- sair");
            Console.WriteLine();

            string opcaoUsuario -Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}