using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange ett lågt tal : ");
        int lowerBound = int.Parse(Console.ReadLine());
        Console.Write("Ange ett högt tal till : ");
        int upperBound = int.Parse(Console.ReadLine());


        Console.WriteLine($"Primtal mellan {lowerBound} och {upperBound} :");

        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (isPrime(i))
            {
                Console.WriteLine(i);
            }
        }

    }
    static bool isPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i  = 3 ; i <= Math.Sqrt(number) ; i += 2)
        {   
            if (number % i == 0)
            {
                return false;
            }


        }

        return true;
       
    }
}