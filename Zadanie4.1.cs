namespace ZadaniaRozdzial4
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            //zad 4.1
            int n, a;
            Console.WriteLine("Podaj ile chcesz miec elementow tablicy: ");
            n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj element tablicy: ");
                a = int.Parse(Console.ReadLine());
                tab[i] = a;
            }

            Console.WriteLine("Wyswietlam twoja tablice:");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

        }
    }
}