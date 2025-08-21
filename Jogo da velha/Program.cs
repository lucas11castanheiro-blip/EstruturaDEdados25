using System;

// Classe principal do programa
class Program
{
    // Matriz que representa o tabuleiro do jogo
    static char[,] tabuleiro = new char[3, 3];
    // Variável para controlar o jogador atual ('X' ou 'O')
    static char jogadorAtual = 'X';

    // Inicia o tabuleiro com os números de 1 a 9
    static void InicializarTabuleiro()
    {
        char contador = '1';
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = contador++;
            }
        }
    }

    static void ExibirTabuleiro()
    {
        Console.Clear(); // Limpa o console para uma exibição mais limpa
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {tabuleiro[0, 0]}  |  {tabuleiro[0, 1]}  |  {tabuleiro[0, 2]}   ");
        Console.WriteLine(" ____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {tabuleiro[1, 0]}  |  {tabuleiro[1, 1]}  |  {tabuleiro[1, 2]}   ");
        Console.WriteLine(" ____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {tabuleiro[2, 0]}  |  {tabuleiro[2, 1]}  |  {tabuleiro[2, 2]}   ");
        Console.WriteLine("     |     |      ");
    }

    static void RealizarJogada()
    {
        bool jogadaValida = false;
        while (!jogadaValida)
        {
            Console.Write($"\nJogador {jogadorAtual}, escolha sua posição (1-9): ");
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                // Lógica para converter a escolha (1-9) para os índices da matriz
                int linha = (escolha - 1) / 3;
                int coluna = (escolha - 1) % 3;

                if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && tabuleiro[linha, coluna] != 'X' && tabuleiro[linha, coluna] != 'O')
                {
                    tabuleiro[linha, coluna] = jogadorAtual;
                    jogadaValida = true;
                }
                else
                {
                    Console.WriteLine("Jogada inválida! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número de 1 a 9.");
            }
        }
    }

    static void TrocarJogador()
    {
        jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
    }

    static bool VerificarVitoria()
    {
        // Verificar linhas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
            {
                return true;
            }
        }

        // Verificar colunas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
            {
                return true;
            }
        }

        // Verificar diagonais
        if ((tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2]) ||
            (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0]))
        {
            return true;
        }

        return false;
    }

    static bool VerificarEmpate()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] != 'X' && tabuleiro[i, j] != 'O')
                {
                    return false; // Ainda existem posições livres
                }
            }
        }
        return true; // Todas as posições estão preenchidas
    }

    static void Main(string[] args)
    {
        InicializarTabuleiro();
        bool fimDeJogo = false;

        while (!fimDeJogo)
        {
            ExibirTabuleiro();
            RealizarJogada();

            if (VerificarVitoria())
            {
                ExibirTabuleiro();
                Console.WriteLine($"\nO jogador {jogadorAtual} venceu!");
                fimDeJogo = true;
            }
            else if (VerificarEmpate())
            {
                ExibirTabuleiro();
                Console.WriteLine("\nO jogo terminou em empate!");
                fimDeJogo = true;
            }
            else
            {
                TrocarJogador();
            }
        }

        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}