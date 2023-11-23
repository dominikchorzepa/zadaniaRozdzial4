using System.Diagnostics.CodeAnalysis;

namespace ZadaniaRozdzial4
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            //zad4.6
            int[,] tab = new int[5, 5]{{ 1, 2, 3, 4, 5 },
                                       { 6, 7, 8, 9, 10},
                                       { 11, 12, 13, 14, 15},
                                       { 16, 17, 18, 19, 20},
                                       { 21, 22, 23, 24, 25} };
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += tab[i, i];
            }
            Console.WriteLine($"Suma przekatnej = {suma}");
        }
    }
}