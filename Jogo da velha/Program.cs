using System;
class Program
{
    // Matriz que representa o tabuleiro do jogo
    static char[,] board = new char[3, 3];
    // Variável para controlar o jogador atual ('X' ou 'O')
    static char currentPlayer = 'X';

    // Inicia o tabuleiro com os números de 1 a 9
    static void InitializeBoard()
    {
        char counter = '1';
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = counter++;
            }
        }
    }

    static void ShowBoard()
    {
        Console.Clear(); // Limpa o console para uma exibição mais limpa
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[0, 0]}  |  {board[0, 1]}  |  {board[0, 2]}   ");
        Console.WriteLine(" ____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[1, 0]}  |  {board[1, 1]}  |  {board[1, 2]}   ");
        Console.WriteLine(" ____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[2, 0]}  |  {board[2, 1]}  |  {board[2, 2]}   ");
        Console.WriteLine("     |     |      ");
    }

    static void MakeMove()
    {
        bool InvalidPlay = false;
        while (!InvalidPlay)
        {
            Console.Write($"\nJogador {currentPlayer}, escolha sua posição (1-9): ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                // Lógica para converter a escolha (1-9) para os índices da matriz
                int line = (choice - 1) / 3;
                int column = (choice - 1) % 3;

                if (line >= 0 && line < 3 && column >= 0 && column < 3 && board[line, column] != 'X' && board[line, column] != 'O')
                {
                    board[line, column] = currentPlayer;
                    InvalidPlay = true;
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

    static void ChangePlayer()
    {
        if(currentPlayer == 'X')
        {
            currentPlayer = 'O';
        }
        else
        {
            currentPlayer = 'X';
        }
    }

    static bool CheckVictory()
    {
        // Verificar linhas
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return true;
            }
        }

        // Verificar colunas
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                return true;
            }
        }

        // Verificar diagonais
        if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) ||
            (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
        {
            return true;
        }

        return false;
    }

    static bool CheckTie()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] != 'X' && board[i, j] != 'O')
                {
                    return false; // Ainda existem posições livres
                }
            }
        }
        return true; // Todas as posições estão preenchidas
    }

    static void Main(string[] args)
    {
        InitializeBoard();
        bool GameOver = false;

        while (!GameOver)
        {
            ShowBoard();
            MakeMove();

            if (CheckVictory())
            {
                ShowBoard();
                Console.WriteLine($"\nO jogador {currentPlayer} venceu!");
                GameOver = true;
            }
            else if (CheckTie())
            {
                ShowBoard();
                Console.WriteLine("\nO jogo terminou em empate!");
                GameOver = true;
            }
            else
            {
                ChangePlayer();
            }
        }

        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}