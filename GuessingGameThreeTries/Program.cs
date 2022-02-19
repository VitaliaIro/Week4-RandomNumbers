using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbri 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on 3 katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbri vaid ühte korda.


       
            int i = 0;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (i < 3)
            {
                Console.WriteLine("Sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number! Sul jäänud {3 - i} katset ");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
