using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat;
            //iga mängija viskab täringut (1-6)
            //programm kuvab nende visete tulemused ja kuvab ka, kes on võitja
            //-ehk kes viskas suuremat

            {
                Random rnd = new Random();

                Console.WriteLine("Mängija 1 sisesta oma nimi");
                string no1 = Console.ReadLine();
                Console.WriteLine("Mängija 2 sisesta oma nimi");
                string no2 = Console.ReadLine();

                int MyRandomNumber = rnd.Next(1, 7);
                Console.WriteLine($"{no1},veeretas {MyRandomNumber}.");
                int MyRandom = rnd.Next(1, 7);
                Console.WriteLine($"no2 ,veeretas" {Myrandom });
            
            
            
            }

                   
        
        } 
    }
}
