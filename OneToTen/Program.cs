using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis numbreid 1 kuni 10

            for (int i = 0; i < 10; i++) //int i = 0; - start; i < 10; - end < i++ = i = i +1 - step(samm)
            {
                Console.WriteLine($"{i + 1 }.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
