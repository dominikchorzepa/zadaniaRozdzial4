namespace ZadaniaRozdzial4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            //zad4.4
            Random rand = new Random();
            int[] tab = new int[100];
            int ilePierwszych = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 1000);
            }

            foreach (int number in tab)
            {
                bool czyPierwsza = true;

                if (number <= 1)
                {
                    czyPierwsza = false;
                }
                else
                {
                    for (int j = 2; j * j <= number; j++)
                    {
                        if (number % j == 0)
                        {
                            czyPierwsza = false;
                            break;
                        }
                    }
                }

                if (czyPierwsza)
                {
                    ilePierwszych++;
                }
            }

            Console.WriteLine("Liczba liczb pierwszych w tablicy: " + ilePierwszych);
        }
    }
}