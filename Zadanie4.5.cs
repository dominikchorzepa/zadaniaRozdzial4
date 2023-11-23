namespace ZadaniaRozdzial4
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            //zad4.5
            int n, a;
            Console.WriteLine("Podaj ile chcesz miec elementow tablicy: ");
            n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            int[] tab2 = new int[n];
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Podaj element tablicy: ");
                a = int.Parse(Console.ReadLine());
                tab1[i] = a;
            }
            Console.WriteLine("Tablica nr.1:");
            Console.WriteLine();
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine($"{i}: {tab1[i]}");
            }

            for (int i = 0; i < tab1.Length; i++)
            {
                tab2[(i + 1) % tab1.Length] = tab1[i];
            }
            Console.WriteLine();

            Console.WriteLine("Tablica nr.2:");
            Console.WriteLine();
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.WriteLine($"{i}: {tab2[i]}");
            }



        }
    }
}