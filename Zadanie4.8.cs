namespace ZadaniaRozdzial4
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            //zad4.8
            string a;
            int ileWyrazow = 0;
            bool inWord = false;
            Console.WriteLine("Podaj jakies zdanie: ");
            a = Console.ReadLine();

            a = a.Trim();

            foreach (char c in a)
            {
                if (c != ' ' && !inWord)
                {
                    ileWyrazow++;
                    inWord = true;
                }
                else if (c == ' ')
                {
                    inWord = false;
                }
            }



            Console.WriteLine($"Napisales {ileWyrazow} wyrazow.");


        }
    }
}