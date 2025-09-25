using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Filas
{
     public class HanoiTowers
    {
        public int DiscsCount { get; set; }
        public int MovesCount { get; set; }
        public Stack<int> From { get; set; } = new Stack<int>();
        public Stack<int> To { get; set; } = new Stack<int>();
        public Stack<int> Auxiliary { get; set; } = new Stack<int>();
    }
    public class InitializeVisualization
    {
        private static int _columnSize = 5; // Tamanho padrão da coluna
        private const int DELAY_MS = 500;   // Delay para visualização (ajuste conforme necessário)

        // Método para visualizar o algoritmo (evento)
        private static void Algorithm_Visualize(object sender, EventArgs e)
        {
            Console.Clear();
            HanoiTowers algorithm = (HanoiTowers)sender;
            if (algorithm.DiscsCount <= 0)
            {
                return;
            }

            char[][] visualization = CreateVisualization(algorithm);

            PrepareColumn(visualization, 1, algorithm.DiscsCount, algorithm.From);
            PrepareColumn(visualization, 2, algorithm.DiscsCount, algorithm.To);
            PrepareColumn(visualization, 3, algorithm.DiscsCount, algorithm.Auxiliary);

            Console.WriteLine(Center("FROM") + Center("TO") + Center("AUXILIARY"));
            DrawVisualization(visualization);
            Console.WriteLine();
            Console.WriteLine($"Number of moves: {algorithm.MovesCount}");
            Console.WriteLine($"Number of discs: {algorithm.DiscsCount}");
            Thread.Sleep(DELAY_MS);
        }

        // Cria a matriz de visualização
        private static char[][] CreateVisualization(HanoiTowers algorithm)
        {
            char[][] visualization = new char[algorithm.DiscsCount][];
            for (int y = 0; y < visualization.Length; y++)
            {
                visualization[y] = new char[_columnSize * 3];
                for (int x = 0; x < _columnSize * 3; x++)
                {
                    visualization[y][x] = ' ';
                }
            }
            return visualization;
        }

        // Desenha a matriz de visualização no console
        private static void DrawVisualization(char[][] visualization)
        {
            for (int y = 0; y < visualization.Length; y++)
            {
                Console.WriteLine(visualization[y]);
            }
        }

        // Centraliza o texto em uma coluna
        private static string Center(string text)
        {
            int margin = (_columnSize - text.Length) / 2;
            return text.PadLeft(margin + text.Length).PadRight(_columnSize);
        }

        // Prepara uma coluna da torre para visualização
        private static void PrepareColumn(char[][] visualization, int column, int discsCount, Stack<int> stack)
        {
            int margin = _columnSize * (column - 1);
            for (int y = 0; y < stack.Count; y++)
            {
                int size = stack.ElementAt(y);
                int row = discsCount - (stack.Count - y);
                int columnStart = margin + discsCount - size;
                int columnEnd = columnStart + GetDiscWidth(size) - 1;

                for (int x = columnStart; x <= columnEnd; x++)
                {
                    visualization[row][x] = '=';
                }
            }
        }

        // Calcula a largura do disco
        private static int GetDiscWidth(int size)
        {
            return size * 2 - 1;
        }
    }
}