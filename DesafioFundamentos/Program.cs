using DesafioFundamentos.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Coloca o encoding para UTF8 para exibir acentuação
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial = 0;
        decimal precoPorHora = 0;

        Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n");

        // Loop para obter um valor válido para o preço inicial
        while (true)
        {
            Console.WriteLine("Digite o preço inicial:");
            if (decimal.TryParse(Console.ReadLine(), out precoInicial) && precoInicial >= 0)
            {
                break;
            }
            Console.WriteLine("Valor inválido, por favor, digite um número maior ou igual a zero.");
        }

        // Loop para obter um valor válido para o preço por hora
        while (true)
        {
            Console.WriteLine("Agora digite o preço por hora:");
            if (decimal.TryParse(Console.ReadLine(), out precoPorHora) && precoPorHora >= 0)
            {
                break;
            }
            Console.WriteLine("Valor inválido, por favor, digite um número maior ou igual a zero.");
        }

        // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

        string opcao = string.Empty;
        bool exibirMenu = true;

        // Realiza o loop do menu
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    es.AdicionarVeiculo();
                    break;

                case "2":
                    Console.Clear();
                    es.RemoverVeiculo();
                    break;

                case "3":
                    Console.Clear();
                    es.ListarVeiculos();
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida, por favor tente novamente.");
                    break;
            }

            if (exibirMenu)
            {
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
        }

        Console.WriteLine("O programa se encerrou");
    }
}
