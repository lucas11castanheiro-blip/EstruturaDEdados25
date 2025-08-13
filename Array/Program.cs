
using System;
using System.Globalization;
using System.Runtime.ExceptionServices;



        Console.WriteLine("");

        Console.WriteLine(
            "Informe seu nome: "
        );

        string? name = Console.ReadLine();

        // ? -> operadir nullabe
        // indica que a variável 
        // pode receber valor nulo

        Console.WriteLine(
            $"Seja bem-vindo {name}"

        );

        //declarando vetor

        int[] Numbers;

        // inicializando valores
        Numbers = new int[0];

        int[] Numbers2 = new int[5];

        Numbers2[0] = 1;
        Numbers2[1] = 2;
        Numbers2[2] = 3;
        Numbers2[3] = 4;
        Numbers2[4] = 5;


        // declarando e inicializando com valores

        int[] numbers3 = new int[] { 0, 1, 2, 3, 4, 5 };

        //simoplificado 
        int[] numbers4 = new int[] { 1, 2, 3, 4, 5 };

        // preenchendo um vetor om os 12 meses do ano

        string[] months = new string[12];

for (int i = 1; i <= 12; i++)
{

    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

    string MonthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
        months[i - 1] = MonthName;


}
foreach (var month in months)
{
    Console.WriteLine(month);
}
// Array multi-dimensional

int[,] numbers52 = new int[5, 2];

int[,,] numbers53 = new int[5, 4, 3];

//inicializando matriz valorada

int[,] nmb = new int[,]
{
    {1,2, -9},
    {5,7,10},
    {6, 115, 54}
};

// Também podemos acessar da seguinte maneira

int myNumber = nmb[2,1];

Console.WriteLine("Imprimindo o valor da matriz");
Console.WriteLine(myNumber);