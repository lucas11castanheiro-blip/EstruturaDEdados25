using System.Collections.Generic;

        void TorreDeHanoi(int n, char origem, char destino, char auxiliar)
        {
            if (n == 1)
            {
                Console.WriteLine($"Mova o disco 1 de {origem} para {destino}");
                return;
            }
            TorreDeHanoi(n - 1, origem, auxiliar, destino);
            Console.WriteLine($"Mova o disco {n} de {origem} para {destino}");
            TorreDeHanoi(n - 1, auxiliar, destino, origem);
        }

        // Exemplo de uso com 3 discos:
        TorreDeHanoi(3, 'A', 'C', 'B');
    
