using System;

namespace TenToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis numbreid 10 kuni 1

            for (int i = 10; i > 0; i--) //int i = 0; - start; i < 10; - end < i++ = i = i +1 - step(samm)
            {
                Console.WriteLine($"{i}.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
