using System;
namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int Result = fun(number);
            Console.WriteLine(Result);
            Console.ReadKey();
        }
        static int fun(int n)
        {
            int Result = 0;
            for(int i = 1; i <= n; i++)
            {
                Result = Result + i;
            }
            return Result;
        }
    }
}