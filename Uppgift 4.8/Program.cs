using System;
namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange triangelns sidlängd:");
            int storlek = int.Parse(Console.ReadLine());

            for (int i = 1; i <= storlek; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}