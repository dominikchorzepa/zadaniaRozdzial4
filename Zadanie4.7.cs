namespace ZadaniaRozdzial4
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            //zad4.7
            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            dniTygodnia[2, 0] = "sroda";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[3, 2] = "donnerstag";
            dniTygodnia[4, 0] = "piatek";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[4, 2] = "freitag";
            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[5, 2] = "samstag";
            dniTygodnia[6, 0] = "niedziela";
            dniTygodnia[6, 1] = "sunday";
            dniTygodnia[6, 2] = "sonntag";

            for (int i = 0; i < dniTygodnia.GetLength(0); i++)
            {
                for (int j = 0; j < dniTygodnia.GetLength(1); j++)
                {
                    Console.Write(dniTygodnia[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
