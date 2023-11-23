namespace ZadaniaRozdzial4
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //zad4.2
            int[] tab1 = new int[10] { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10 };
            int[] tab2 = new int[10];
            int tab2Index = 0;

            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] >= 0)
                {
                    tab2[tab2Index] = tab1[i];
                    tab2Index++;
                }
                if (tab2Index >= 10)
                {
                    break;
                }
            }
            foreach (int item in tab2)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}