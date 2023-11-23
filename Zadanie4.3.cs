namespace ZadaniaRozdzial4
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            //zad4.3
            int n, a, max, min, pozycja = 0, suma = 0, ileDodatnich = 0;

            Console.WriteLine("Podaj ile chcesz miec elementow tablicy: ");
            n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj element tablicy: ");
                a = int.Parse(Console.ReadLine());
                tab[i] = a;
            }
            Console.WriteLine("Twoja tablica: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                    pozycja = i;
                }
            }
            Console.WriteLine($"Max element: {max}, na pozycji {pozycja}");

            min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                    pozycja = i;
                }
            }
            Console.WriteLine($"Min element to: {min}, na pozycji {pozycja}");

            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            Console.WriteLine($"Srednia wszystkich elementow to: {suma / (double)n}");

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] >= 0)
                {
                    ileDodatnich++;
                }
            }
            Console.WriteLine($"Liczba elementow dodatnich to: {ileDodatnich}");
        }
    }
}