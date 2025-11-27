/*Atividade 1 — Busca em vetor simples

Enunciado:
Crie um programa em C# que:
Peça ao usuário para digitar 5 números inteiros e armazene-os em um vetor.
Peça em seguida um número para buscar.
Use busca linear para verificar se o número está no vetor e informe a posição ou diga que não foi encontrado.

Dica:
Use um for para percorrer o vetor e compare elemento por elemento.
*/

using System;

string[] numbers = new string[5];

Console.WriteLine("\n\tDigite 5 números inteiros:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Número {i + 1}: ");
    numbers[i] = Console.ReadLine();
}

Console.Write("\n\tDigite um número para buscar: ");
string searchNumber = Console.ReadLine();

int position = Array.IndexOf(numbers, searchNumber);

if (position != -1)
{
    Console.WriteLine($"Número encontrado na posição: {position+1}");
}
else
{
    Console.WriteLine("Número não encontrado no vetor.");
}
