using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbri 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbri vaid ühte korda.


            bool loopActive = true;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (loopActive)
            {
                Console.WriteLine("Sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    loopActive = false;
                }
                else
                {                   
                    Console.WriteLine("Vale number. Proovi uuesti!");                   
                }
            }

            Console.WriteLine("Kena päeva!");
            





        }
    }
}
