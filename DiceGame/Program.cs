using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user) 
            //Mõlemad mängijad viskavad täringud;
            //Programm kontrollib, kumb mängija viskas rohkem;
            //Mängija, kes viskab rohkem on mängu võitja. 
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja 


            /*for(int i = 0; i < 10; i++) //int i = 0; - start; i < 10; - end < i++ = i = i +1 - step(samm)
            {
                Console.WriteLine($"{i + 1  }. I will not skateboard in the halls.".ToUpper());
            }

            Console.WriteLine("Kena päeva!"); */



            Random rnd = new Random();

            int cpuScore = 0; 
            int userScore = 0;


            for(int i = 0; i < 3; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);
                cpuScore = cpuScore + cpuRandom;
                userScore = userScore + userRandom;
                Console.WriteLine($"Arvuti viskas {cpuRandom} ja kasutaja viskas {userRandom}.");
            }
            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                userScore = userScore + 1;
            }
            else if(cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud. Palju õnne!");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik!");
            }
        }
    }
}
