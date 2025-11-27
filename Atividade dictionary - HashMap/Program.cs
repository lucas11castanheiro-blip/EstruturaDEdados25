using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, string> rastreamento = new Dictionary<string, string>();
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n\t=== SISTEMA DE RASTREAMENTO DE ENTREGA ===\n\n");
            Console.WriteLine("1. Adicionar rastreamento");
            Console.WriteLine("2. Buscar por código de rastreio");
            Console.WriteLine("3. Buscar por código de barras");
            Console.WriteLine("4. Listar todos os rastreamentos");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("❌ Opção inválida!");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarRastreamento(rastreamento);
                    break;
                case 2:
                    BuscarPorRastreio(rastreamento);
                    break;
                case 3:
                    BuscarPorBarras(rastreamento);
                    break;
                case 4:
                    ListarTodos(rastreamento);
                    break;
                case 5:
                    Console.WriteLine("👋 Encerrando sistema...");
                    break;
                default:
                    Console.WriteLine("❌ Opção inválida!");
                    break;
            }
        }
    }

    static void AdicionarRastreamento(Dictionary<string, string> rastreamento)
    {
        Console.Write("\nDigite o código de rastreio: ");
        string rastreio = Console.ReadLine()?.Trim() ?? "";

        if (string.IsNullOrEmpty(rastreio))
        {
            Console.WriteLine("❌ Código de rastreio não pode estar vazio!");
            return;
        }

        if (rastreamento.ContainsKey(rastreio))
        {
            Console.WriteLine("⚠️  Já existe um rastreamento com este código!");
            return;
        }

        Console.Write("Digite o código de barras: ");
        string barras = Console.ReadLine()?.Trim() ?? "";

        if (string.IsNullOrEmpty(barras))
        {
            Console.WriteLine("❌ Código de barras não pode estar vazio!");
            return;
        }

        rastreamento[rastreio] = barras;
        Console.WriteLine("✅ Rastreamento adicionado com sucesso!");
    }

    static void BuscarPorRastreio(Dictionary<string, string> rastreamento)
    {
        Console.Write("\nDigite o código de rastreio: ");
        string rastreio = Console.ReadLine()?.Trim() ?? "";

        if (rastreamento.TryGetValue(rastreio, out string barras))
        {
            Console.WriteLine($"\n✅ Rastreamento encontrado!");
            Console.WriteLine($"📍 Código de rastreio: {rastreio}");
            Console.WriteLine($"📦 Código de barras: {barras}");
        }
        else
        {
            Console.WriteLine("❌ Nenhum rastreamento encontrado com este código!");
        }
    }

    static void BuscarPorBarras(Dictionary<string, string> rastreamento)
    {
        Console.Write("\nDigite o código de barras: ");
        string barras = Console.ReadLine()?.Trim() ?? "";

        var resultado = rastreamento.FirstOrDefault(x => x.Value == barras);

        if (resultado.Key != null)
        {
            Console.WriteLine($"\n✅ Pacote encontrado!");
            Console.WriteLine($"📍 Código de rastreio: {resultado.Key}");
            Console.WriteLine($"📦 Código de barras: {resultado.Value}");
        }
        else
        {
            Console.WriteLine("❌ Nenhum pacote encontrado com este código de barras!");
        }
    }

    static void ListarTodos(Dictionary<string, string> rastreamento)
    {
        if (rastreamento.Count == 0)
        {
            Console.WriteLine("\n📭 Nenhum rastreamento cadastrado!");
            return;
        }

        Console.WriteLine("\n=== LISTA DE RASTREAMENTOS ===");
        int i = 1;
        foreach (var item in rastreamento)
        {
            Console.WriteLine($"{i}. Rastreio: {item.Key} | Barras: {item.Value}");
            i++;
        }
    }
}
